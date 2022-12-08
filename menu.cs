using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;   

namespace Licence
{
    public partial class menu : Form
    {
        string volet = "";

        public menu()
        {
            InitializeComponent();
            
            
        }


       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void agenda_Click(object sender, EventArgs e)
        {
            volet = "agenda";
            planning age = new planning ();
            age.Show();
        }
        private void point_Click(object sender, EventArgs e)
        {
            pntControle point=new pntControle();
            point.Show();

        }

        private void suivi_Click(object sender, EventArgs e)
        {
            volet = "suivi";
            charger_les_suivis(); 
        }
        private void charger_les_suivis()
        {
            connexion co = new connexion();
            DataSet ds = new DataSet();

            string req = "select T.idpoint as CodePNT, A.IDagenda as code ,T.type_de_regelement as Textregelment , T.nature as nature , T.type_de_controle as typeControle, T.objet as objet  , T.categorie as categorie , T.point_de_controle as pointdecontrole , T.structure_concernee as structureconcernee ,T.penality as penality ,  T.limpact as impact , T.scor_dimpact as score, A.date_controle from  agenda A, Table_point_de_controle T " +
             " where  T.idpoint = A.id_pnt and " +
              "id_source is not null and statue is null ";

            co.getdataset(req, "[Table_point_de_controle]", ds);
            dg_affichage.AutoGenerateColumns = true;
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[Table_point_de_controle]";
            dg_affichage.Columns["CodePNT"].Visible = false;


        }



        private void reporting_Click(object sender, EventArgs e)
        {
            volet = "reporting";
            connexion co = new connexion();
            DataSet ds = new DataSet();
            //point_controle, texte_regl, date_controle, date_envois, constats, recommendations, score, impact, structure);
            string req = "select T.idpoint as CodePNT, A.IDagenda as code ,T.type_de_regelement as Textregelment , T.point_de_controle as pointdecontrole , T.structure_concernee as structureconcernee , T.limpact as impact , T.scor_dimpact as score, A.date_controle, A.constat, A.recommandation,A.statue as Etat from  agenda A, Table_point_de_controle T " +
             " where  T.idpoint = A.id_pnt and " +
              " statue is not null ";

            co.getdataset(req, "[Table_point_de_controle]", ds);
            dg_affichage.AutoGenerateColumns = true;
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[Table_point_de_controle]";
            dg_affichage.Columns["CodePNT"].Visible = false;



        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fichierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nouveauFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("affiche " );  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            volet = "pointcontrole";
            charger_les_points_controles();
        }
        private void charger_les_points_controles()
        {
            connexion co = new connexion();
            DataSet ds = new DataSet();
            string req = "SELECT  [idpoint],[point_de_controle] as Nom,[type_de_regelement] ,[objet] ,[date_dentree_en_vigeur] FROM [Cregulatory].[dbo].[Table_point_de_controle] order by idpoint desc ";
            co.getdataset(req, "[Table_point_de_controle]", ds);
            dg_affichage.AutoGenerateColumns = true; 
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[Table_point_de_controle]";


        }

        private void quitte_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void uneStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show(); 
        }

        private void dg_affichage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_affichage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (volet == "pointcontrole")
            {
                int i = dg_affichage.CurrentRow.Index;
                string code = dg_affichage.Rows[i].Cells["idpoint"].Value.ToString();

                pntControle pntControle = new pntControle(code);
                pntControle.Show(); 


                

            }
                if (volet == "suivi")
            {
                int i = dg_affichage.CurrentRow.Index;
                string textreglementaire = dg_affichage.Rows[i].Cells["Textregelment"].Value.ToString();



                string codepnt = dg_affichage.Rows[i].Cells["CodePNT"].Value.ToString();


                string categ = dg_affichage.Rows[i].Cells["categorie"].Value.ToString();

                string objeet = dg_affichage.Rows[i].Cells["objet"].Value.ToString();



                string natuure = dg_affichage.Rows[i].Cells["nature"].Value.ToString();


                string pointt = dg_affichage.Rows[i].Cells["pointdecontrole"].Value.ToString();



                string typedcontrl = dg_affichage.Rows[i].Cells["typeControle"].Value.ToString();


                string structure = dg_affichage.Rows[i].Cells["structureconcernee"].Value.ToString();



                string penalite = dg_affichage.Rows[i].Cells["penality"].Value.ToString();


                string scor = dg_affichage.Rows[i].Cells["score"].Value.ToString();



                string impactt = dg_affichage.Rows[i].Cells["impact"].Value.ToString();



                string code = dg_affichage.Rows[i].Cells["code"].Value.ToString();

                suivi2 c = new suivi2(codepnt, code, impactt, categ, natuure, scor, pointt, penalite, structure, typedcontrl, objeet, textreglementaire);
                c.Show();
                //suivi2 c = new suivi2();
                //c.Show();


            }
           if(volet=="reporting")

            {


                //  PDFdocuments.CreateReproting()  
                int i = dg_affichage.CurrentRow.Index;
                string textreglementaire = dg_affichage.Rows[i].Cells["Textregelment"].Value.ToString();

                string codepnt = dg_affichage.Rows[i].Cells["CodePNT"].Value.ToString();

                string pointt = dg_affichage.Rows[i].Cells["pointdecontrole"].Value.ToString();

                string structure = dg_affichage.Rows[i].Cells["structureconcernee"].Value.ToString();
                string scor = dg_affichage.Rows[i].Cells["score"].Value.ToString();

                string impactt = dg_affichage.Rows[i].Cells["impact"].Value.ToString(); 
                 string recommandation  = dg_affichage.Rows[i].Cells["recommandation"].Value.ToString();
                string constat = dg_affichage.Rows[i].Cells["constat"].Value.ToString();
                string datedecontrole = dg_affichage.Rows[i].Cells["date_controle"].Value.ToString();


                PDFdocuments.CreateReproting("", pointt, textreglementaire, datedecontrole, DateTime.Today.ToString(), constat, recommandation, scor, impactt, structure);

            }


        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chercherpointsdecontrole();
              }
        private void chercherpointsdecontrole()
        {
            string condition = " where 1=1  ";
            string text = pointcontrole.Text;
            if (pointcontrole.Text != "")
            {


                condition = condition + "  and point_de_controle like '" + pointcontrole.Text + "%'";

            }

            if (type_texte.Text != "")
            {


                condition = condition + "  and type_de_regelement like '" + type_texte.Text + "%'";

            }
           
           

            string req = "SELECT  [idpoint],[point_de_controle] as Nom,[type_de_regelement] ,[objet] ,[date_dentree_en_vigeur] from Table_point_de_controle  "+condition;
            DataSet ds = new DataSet();
            connexion c = new connexion();
            c.getdataset(req, "[Table_point_de_controle]", ds);
            dg_affichage.AutoGenerateColumns = true;
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[Table_point_de_controle]";


        }

        private void type_texte_TextChanged(object sender, EventArgs e)
        {
            chercherpointsdecontrole();
        }

        private void ajouterUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
        }

        private void rechreporting_TextChanged(object sender, EventArgs e)
        {
            chercherreporting();
        }
        private void chercherreporting()
        {
            volet = "recherche"; 
            string condition = " where 1=1 and statue is not null";
            string text = rechreporting.Text;
            if (rechreporting.Text != "") 
            {


                condition = condition + "  and type_de_regelement  like '" + rechreporting.Text + "%'";

            }
            
            string req = "select T.idpoint as CodePNT, A.IDagenda as code ,T.type_de_regelement as Textregelment   , T.point_de_controle as pointdecontrole , T.structure_concernee as structureconcernee  ,  T.limpact as impact , T.scor_dimpact as score, A.date_controle ,A.constat,A.recommandation from  agenda A, Table_point_de_controle T " + condition;
            DataSet ds = new DataSet();
            connexion c = new connexion();
            c.getdataset(req, "[Table_point_de_controle]", ds);
            dg_affichage.AutoGenerateColumns = true;
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[Table_point_de_controle]";
        }
      
           
        private void rechsuivi_TextChanged(object sender, EventArgs e)
        {
            cherchersuivi();
        }
        private void cherchersuivi()
        {
            string condition = " where 1=1  ";
            string text = rechsuivi.Text;
            if (rechsuivi.Text != "")
            {


                condition = condition + "  and scorimpact  like '" + rechsuivi.Text + "%'";

            }
            string req = "SELECT  [id_pnt],[statue] as Nom,[scorimpact]  from agenda   " + condition;
            DataSet ds = new DataSet();
            connexion c = new connexion();
            c.getdataset(req, "[agenda]", ds);
            dg_affichage.AutoGenerateColumns = true;
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[agenda]"; 

          }

        private void rechreporting_Click(object sender, EventArgs e)
        {
            if (rechreporting.Text == "type de réglement")
            { rechreporting.Text = "";

                //rechreporting.Font = new Font("Arial",Color.Black,Font.InitializeLifetimeService);
            }
        }

        private void rechreporting_Leave(object sender, EventArgs e)
        {
            if (rechreporting.Text.Trim() == "")
            {
                rechreporting.Text = "type de réglement";


            }
        }

        private void rechsuivi_Click(object sender, EventArgs e)
        {
            if (rechreporting.Text == "score d'impact")
            {
                rechreporting.Text = "";

                //rechreporting.Font = new Font("Arial",Color.Black,Font.InitializeLifetimeService);
            }
        }

        private void rechsuivi_Leave(object sender, EventArgs e)
        {
            if (rechreporting.Text.Trim() == "")
            {
                rechreporting.Text = "score d'impact";


            }
        }

        private void pleinEcranToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* private void textBox1_TextChanged(object sender, EventArgs e)
{
string recherche =this.textBox1.
}

private void chercherToolStripMenuItem_Click(object sender, EventArgs e)
{
string chercher = this.
}*/
    }
    }                   
