using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Licence
{
    public partial class pntControle : Form
    {
        string CODEONT = "0";
        string niveau_conformite = "";
        string ancien_pr = "";
        string ancien_nb = "";
        private string? code;

        public pntControle()
        {
            InitializeComponent();
        }

        public pntControle(string? code)
        {
            InitializeComponent();

            this.CODEONT = code;
            string req = "select * from Table_point_de_controle where idpoint=" + CODEONT;
            DataSet ds = new DataSet();
            connexion c = new connexion();
            c.getdataset(req, "Table_point_de_controle", ds);
            //récuperation de  valuers
            if (ds.Tables["Table_point_de_controle"].Rows.Count > 0)
            {
                m_typereg.Text = ds.Tables["Table_point_de_controle"].Rows[0]["type_de_regelement"].ToString(); m_typereg.Text = ds.Tables["Table_point_de_controle"].Rows[0]["type_de_regelement"].ToString() ;

        

                
                pd_objet.Text = ds.Tables["Table_point_de_controle"].Rows[0]["objet"].ToString();
                nature5.Text = ds.Tables["Table_point_de_controle"].Rows[0]["nature"].ToString();
                dateu.Text = ds.Tables["Table_point_de_controle"].Rows[0]["date_demission"].ToString();
                datey.Text = ds.Tables["Table_point_de_controle"].Rows[0]["date_dentree_en_vigeur"].ToString();
                categorie.Text = ds.Tables["Table_point_de_controle"].Rows[0]["categorie"].ToString();
                resumer.Text = ds.Tables["Table_point_de_controle"].Rows[0]["resumer"].ToString();
                pointh.Text = ds.Tables["Table_point_de_controle"].Rows[0]["point_de_controle"].ToString();
                structureg.Text = ds.Tables["Table_point_de_controle"].Rows[0]["structure_concernee"].ToString();
                perdnbr.Text = ds.Tables["Table_point_de_controle"].Rows[0]["nbr_peroid"].ToString();
                ancien_nb = perdnbr.Text;


                
                niveau.Text = ds.Tables["Table_point_de_controle"].Rows[0]["niveau_de_conformite"].ToString();
                niveau_conformite = niveau.Text; 
                
                
                scorea.Text = ds.Tables["Table_point_de_controle"].Rows[0]["scor_dimpact"].ToString();
                impacth.Text = ds.Tables["Table_point_de_controle"].Rows[0]["limpact"].ToString();
                typev.Text = ds.Tables["Table_point_de_controle"].Rows[0]["type_de_controle"].ToString();
                pn_conf.Text = ds.Tables["Table_point_de_controle"].Rows[0]["penality"].ToString();
                comboBox1.Text = ds.Tables["Table_point_de_controle"].Rows[0]["peroid"].ToString();
                ancien_pr = comboBox1.Text;






            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (CODEONT == "0")
            {
                //ajouter un nouveau poit de controle
                string id_pnt = ParametragePointdeControle();
                string idsource = AjoutPointControle(id_pnt, niveau.Text, scorea.Text, pn_conf.Text, impacth.Text);
                planifincation(id_pnt, comboBox1.Text, Convert.ToInt32(perdnbr.Text));



                if (niveau.Text != "conforme")
                {
                    DateTime datesuivi_ = Convert.ToDateTime(Convert.ToDateTime(DateControle.Text).ToShortDateString());// DateTime.Today;
                    ajouterunsuivi(id_pnt, idsource, scorea.Text, niveau.Text, datesuivi_);//, scorea.Text, pn_conf.Text, impacth.Text);
                    envoidemail(structureg.SelectedValue.ToString(), pointh.Text, impacth.Text, pn_conf.Text, niveau.Text);
                }
                MessageBox.Show("le point de controle a été bien enregister!");
                if (niveau.Text == "conforme" && MessageBox.Show("Voulez-vous générer un reporting  ? ", " ",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                {
                    //génération de reporting 
                    PDFdocuments.CreateReproting("", pointh.Text, m_typereg.Text, Convert.ToDateTime(DateControle.Text).ToShortDateString(), DateTime.Today.ToString(), "", "", scorea.Text, impacth.Text, structureg.Text);
                }


            }
            else {

                if(MessageBox.Show("Voulez-vous enregistrer les modification ? ", " Attention certains modification peuvent touchez à la programmation des prochains point de contrôle et la planfication des suivis",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                { 
                //update point de controle 
                UpdatePNT();


                //modifier period:
                if (ancien_pr != comboBox1.Text || ancien_nb != perdnbr.Text)
                {
                    replanification();
                }


                //modifier le niveau de conformité:
                if (niveau_conformite != niveau.Text)
                { //conforme -->non-conforme : ajouter un suivi
                    if (niveau.Text != "conforme")
                    {
                            DateTime datesuivi_ = Convert.ToDateTime(Convert.ToDateTime(DateControle.Text).ToShortDateString());// DateTime.Today;
                            ajouterunsuivi(CODEONT, CODEONT, scorea.Text, niveau.Text, datesuivi_);//, scorea.Text, pn_conf.Text, impacth.Text);
                        envoidemail(structureg.SelectedValue.ToString(), pointh.Text, impacth.Text, pn_conf.Text, niveau.Text);

                    }
                    else
                    {
                        //non-conforme--> conforme: supprimer l'ancien suivi  
                        Delet_SUIVI(CODEONT);
                    }
                }

                }

            }

            this.Close();


            

        }

        private void replanification()
        {
            //supprime les anciens 
            string req = "delete From agenda where id_pnt=" + CODEONT+" and statue is null";
            connexion c = new connexion();
            c.executscalar(req);

            //planification avec les nouvelle dates:

            planifincation(CODEONT, comboBox1.Text, Convert.ToInt32(perdnbr.Text));


        }
        private void Delet_SUIVI(string code)

        {
            string req = "delete from agenda where id_source=" + code;

            connexion c = new connexion();
            c.executscalar(req);
        }
        private void envoidemail(string struc,string ptc,string impa,string penal,string nivcon)
        {
            string dist = "Select * from Structures where id_structure =" + struc;
            DataSet ds = new DataSet();
            connexion con = new connexion(); 
            con.getdataset(dist,"Structures", ds);
            string  nom_str=ds.Tables["Structures"].Rows[0]["nom_structure"].ToString();
            string email_str = ds.Tables["Structures"].Rows[0]["email_structure"].ToString();

            string mail = "";
        }
        private string AjoutPointControle(string id_pnt, string niv_, string scorimpact, string penalite, string impact)
        {
            
            connexion c = new connexion();
/*            string req = " insert INTO[Cregulatory].[dbo].[agenda] " +
             "([id_pnt],[date_controle],statue) values (" + id_pnt + ",'" + DateTime.Today.ToString() + "','"+niv_+"')";
  */
                string req = "INSERT INTO [Cregulatory].[dbo].[agenda] ([id_pnt],[date_controle],statue ,[scorimpact],[penalite] ,[impact])" +
   "   VALUES (" + id_pnt + ",'" + DateControle.Text.ToString() + "','" + niv_ + "','" + scorimpact + "','" + penalite + "','" + impact + "')";

            return (c.GetIDexecutscalar(req)).ToString();

        }
     

        private string ParametragePointdeControle()
        {


            string type_de_regelement = "";
            string objet = "";
            string nature = "";
            string date_demission = "";
            string date_dentree_en_vigeur = "";
            string categorie = "";
            string resumer = "";
            string point_de_controle = "";
            string structure_concernee = "";
            string nbper = "";
            string per = "";
            string niveau_de_conformite = "";
            string scor_dimpact = "";
            string limpact = "";
            string type_de_controle = "";
            string penality = "";

            type_de_regelement = m_typereg.Text.Replace("' ", "'");
            objet = pd_objet.Text.Replace("'", "''");
            nature = nature5.Text.Replace("'", "''");
            date_demission = datey.Text.Replace("'", "''");
            date_dentree_en_vigeur = dateu.Text.Replace("'", "''");
            categorie = this.categorie.Text.Replace("'", "''");
            resumer = this.resumer.Text.Replace("'", "''");
            point_de_controle = pointh.Text.Replace("'", "''");
            structure_concernee = structureg.Text.Replace("'", "''");
            if (perdnbr.Text == "")
                perdnbr.Text = "0";
            nbper = perdnbr.Text.Replace("'", "''");
            per = comboBox1.Text.Replace("'", "''");
            niveau_de_conformite = niveau.Text.Replace("'", "''");
            scor_dimpact = scorea.Text.Replace("'", "''");
            limpact = impacth.Text.Replace("'", "''");
            type_de_controle = typev.Text.Replace("'", "''");
            penality = pn_conf.Text.Replace("'", "''");

            connexion con = new connexion();
            string req = "INSERT INTO[Cregulatory].[dbo].[Table_point_de_controle] " +
           " ([type_de_regelement]" +
           " ,[objet]" +
           " ,[nature]" +
           " ,[date_demission]" +
           " ,[date_dentree_en_vigeur]" +
           " ,[categorie]" +
           " ,[resumer]" +
           " ,[point_de_controle]" +
           " ,[structure_concernee]" +
           " ,[nbr_peroid]" +
           " ,[peroid]" +
           " ,[niveau_de_conformite]" +
           " ,[scor_dimpact]" +
           " ,[limpact]" +
           " ,[penality]" +
           " ,[type_de_controle])" +
          "   VALUES (" +
          " '" + type_de_regelement + "'," +
          " '" + objet + "'," +
          " '" + nature + "'," +
          " '" + date_demission + "'," +
          " '" + date_dentree_en_vigeur + "'," +
          " '" + categorie + "'," +
          " '" + resumer + "'," +
          " '" + point_de_controle + "'," +
          " '" + structure_concernee + "'," +
          " " + nbper + "," +
          " '" + per + "'," +
          " '" + niveau_de_conformite + "'," +
          " '" + scor_dimpact + "'," +
          " '" + limpact + "'," +
         " '" + penality + "'," +
         " '" + type_de_controle + "')";

            int id_ct = con.GetIDexecutscalar(req);
            return id_ct.ToString();


        }
        private void planifincation(string id_pnt, string per, int nbr_prd)
        {
            DateTime auj =Convert.ToDateTime( Convert.ToDateTime(DateControle.Text).ToShortDateString());// DateTime.Today;
            int nb_rep = 1;
           
                        if (per == "MOIS")
                        {

                            nb_rep = 24 / nbr_prd;

                                connexion c = new connexion();


                                for (int i = 1; i < nb_rep; i++)
                                {
                                    DateTime d1 = auj.AddMonths(nbr_prd * i);

                                    string req = " insert INTO[Cregulatory].[dbo].[agenda] " +
                           "([id_pnt],[date_controle]) values (" + id_pnt + ",'" + d1.ToString() + "')";

                                    c.executscalar(req);

                                }
            }
                        else

                        {
                            if (per == "ANNEE")
                            {
                             nb_rep = 2/ nbr_prd;

                    connexion c = new connexion();


                    for (int i = 1; i < nb_rep; i++)
                    {
                        DateTime d1 = auj.AddYears(nbr_prd *i);

                        string req = " insert INTO[Cregulatory].[dbo].[agenda] " +
               "([id_pnt],[date_controle]) values (" + id_pnt + ",'" + d1.ToString() + "')";

                        c.executscalar(req);

                    }
                }
                            else

                            {
                                if (per == "JOUR")
                                {
                                    nb_rep = 720 / nbr_prd;

                        connexion c = new connexion();


                        for (int i = 1; i < nb_rep; i++)
                        {
                            DateTime d1 = auj.AddDays(nbr_prd * i);

                            string req = " insert INTO[Cregulatory].[dbo].[agenda] " +
                   "([id_pnt],[date_controle]) values (" + id_pnt + ",'" + d1.ToString() + "')";

                            c.executscalar(req);

                        }
                    }
                                else
                                {
                                    if (per=="SEMAINE")
                                    {
                                      nb_rep=96/nbr_prd  ;

                            connexion c = new connexion();


                            for (int i = 1; i < nb_rep; i++)
                            {
                                DateTime d1 = auj.AddDays(((nbr_prd *7)+1)* i); 

                                string req = " insert INTO[Cregulatory].[dbo].[agenda] " +
                       "([id_pnt],[date_controle]) values (" + id_pnt + ",'" + d1.ToString() + "')";

                                c.executscalar(req);

                            }
                        }
                                }


                            }
                        }







            



        }
        private void pntControle_Load(object sender, EventArgs e)
        {
            //charger le champ structure:
            connexion con = new connexion();
            string req = "select id_structure, nom_structure from Structures ";

            DataSet ds = new DataSet();
            con.getdataset(req, "Structures", ds);
            structureg.DataSource = ds.Tables["Structures"]; 
            structureg.ValueMember = "id_structure";
            structureg.DisplayMember = "nom_structure";
            



        }

        private void perdnbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (niveau.Text == "conforme")
            {
                scorea.Text = "";
                scorea.Enabled = false;



                pn_conf.Text = "";
                pn_conf.Enabled = false;


            }
            else
            { scorea.Enabled = true;
                pn_conf.Enabled = true;
            }
        }

        private void typev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nature_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void datesuivi_TextChanged(object sender, EventArgs e)
        {
            
             
        }
        public void ajouterunsuivi(string id_pnt, string id_source, string score, string niv, DateTime datesuivi_)
        {// ajouter les conditions de l'impact .   
            
                if (niv != "conforme")
                {
                   
                    if (score == "Faible") { datesuivi_ = datesuivi_.AddMonths(9); }
                    else
                    {
                        if (score == "moyen") { datesuivi_ = datesuivi_.AddMonths(6); }
                        else { datesuivi_ = datesuivi_.AddMonths(3); }
                    }
                    //datesuivi.Text = datesuivi_.ToString();
                }

            


            connexion c = new connexion();
            string req = "INSERT INTO [Cregulatory].[dbo].[agenda] ([id_pnt],[id_source] ,[date_controle] )" +
   "   VALUES (" + id_pnt + "," + id_source + ",'" + datesuivi_.ToString() + "')";

            c.GetIDexecutscalar(req);
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void type_de_reglment_Click(object sender, EventArgs e)
        {

        }

        private void m_typereg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void objet_Click(object sender, EventArgs e)
        {

        }

        private void pd_objet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nature5_TextChanged(object sender, EventArgs e)
        {

        }

        private void resumer_TextChanged(object sender, EventArgs e)
        {

        }

        private void datey_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void categorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pointh_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_conf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scorea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void structureg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void impacth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //génération d'un reporting
            PDFdocuments.CreateReproting("", pointh.Text, m_typereg.Text, DateControle.Text, DateTime.Today.ToString(), "", "", scorea.Text, impacth.Text, structureg.Text);

        }

        //update point de controle

        private void UpdatePNT()
        {
            string req = "UPDATE [Cregulatory].[dbo].[Table_point_de_controle] " +
      " SET[type_de_regelement] = '" + m_typereg.Text + "'" +
       "   ,[objet] = '" + pd_objet.Text + "'" +
    "  ,[nature] = '" + nature5.Text + "'" +
      ",[date_demission] = '" + dateu.Text + "'" +
      ",[date_dentree_en_vigeur] = '" + datey.Text + "'" +
      ",[categorie] = '" + categorie.Text + "'" +
      ",[resumer] = '" + resumer.Text + "'" +
      ",[point_de_controle] = '" + pointh.Text + "'" +
      ",[structure_concernee] = '" + structureg.Text + "'" +
      ",[nbr_peroid] = '" + perdnbr.Text + "'" +
      ",[niveau_de_conformite] = '" + niveau.Text + "'" +
      ",[scor_dimpact] = '" + scorea.Text + "'" +
      ",[limpact] = '" + impacth.Text + "'" +
      ",[type_de_controle] = '" + typev.Text + "'" +
      ",[penality] = '" + pn_conf.Text + "'" +
      ",[peroid] = '" + comboBox1.Text + "'" +
    " WHERE  idpoint=" + CODEONT;



            string req2 = "UPDATE [Cregulatory].[dbo].[agenda] set " +
    "   [statue] = '" + niveau.Text.Trim() + "'" +
     "  ,[date_controle] = '" + DateControle.Text + "'" +
     "  ,[scorimpact] ='" + scorea.Text + "'" +
      " ,[penalite] = '" + pn_conf.Text + "'" +
     "  ,[impact] = '" + impacth.Text + "'" +
      " ,[constat] =''" +
       ",[recommandation] =''" +
      " ,[reponse_structure] = ''" +
  " WHERE id_pnt=" + CODEONT + " and  statue is not null ";
            connexion c = new connexion();
            c.executscalar(req);
            c.executscalar(req2);



        }


    }
}


