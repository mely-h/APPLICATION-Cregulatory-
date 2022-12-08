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
    public partial class suivi2 : Form
    {
        private string codepnt, textreglementaire, categ , code , natuure , impactt , scor  , point , typedcontrl , penalite , pointt , structure , objeet  ;

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void penalite2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pn_conf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void repon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private int codeagenda;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            connexion c = new connexion();

            if (textBox3.Text == "conforme") { 
                string req = "update agenda set statue='conforme',constat='"+constat.Text+"' , recommandation='"+recom.Text+ "', reponse_structure='" + repon.Text+ "' where IDagenda=" + this.code;
                c.executscalar(req);
             
            }
            else
            { //enregistrer ce suivi non conforme string req="update agenda set status='non-conforme', date_controle='"+Date.Today()+"' where idagenda="+this.code; //reprogrammer une autre date pour le prochain suivi }
                string req = "update agenda set statue='"+textBox3.Text+"',constat='" + constat.Text + "' , recommandation='" + recom.Text + "', reponse_structure='" + repon.Text + "',  scorimpact ='" + scordimpact2.Text + "', penalite='" + penalite2.Text + "' , impact='" + impact2.Text + "'  where IDagenda= " + this.code;
                c.executscalar(req);
                string req2 = "update Table_point_de_controle set scor_dimpact ='" + scordimpact2.Text + "', penality='" + penalite2.Text + "' , limpact='" + impact2.Text + "' where idpoint=" + codepnt;
                c.executscalar(req2); 

                //programmer le prochaine suivi
                pntControle pnt_pour_suivi= new pntControle();
               
                pnt_pour_suivi.ajouterunsuivi(this.codepnt, this.code, scordimpact2.Text, niveau.Text, DateTime.Today);
;            }

            MessageBox.Show("Enregistrement validé!");
            this.Close(); 

           } 

        public suivi2()
        {
            InitializeComponent();
        }

        /*public suivi2(string codepnt,string  textreglementaire , string categ , string natuure , string scor , string impactt , string typedcontrl,string penalite, string pointt  , string structure ,string objeet , string  code  )   
        {
            InitializeComponent(); 
            this.textreglementaire = textreglementaire;
            this.categ = categ;
            this.natuure = natuure;
            this.impactt = impactt;
            this.objeet = objeet;
            this.pointt = pointt;
            this.scor = scor;
            this.typedcontrl = typedcontrl;
            this.code = code; 
            this.typedcontrl = typedcontrl;
            this.penalite = penalite;
            this.structure = structure;

            this.codepnt = codepnt;
           

        }
        */
        public suivi2(string? codepnt,string codesuivi, string? impactt, string? categ, string? natuure, string? scor, string? pointt, string? penalite, string? structure, string? typedcontrl, string? objeet, string? textreglementaire)
        {
            InitializeComponent();
            this.codepnt = codepnt;
            this.impactt = impactt;
            this.categ = categ;
            this.natuure = natuure;
            this.scor = scor;
            this.pointt = pointt;
            this.penalite = penalite;
            this.structure = structure;
            this.typedcontrl = typedcontrl;
            this.objeet = objeet;
            this.textreglementaire = textreglementaire;
            this.code = codesuivi; 
            niveau.Text= "non-conforme";
            panel5.Enabled = false; 

            panel10.Visible = true;
        }

        public suivi2(int codeagenda) 

        {
            InitializeComponent();
            panel10.Visible = false;
            this.codeagenda = codeagenda;
            string rep = "select * from agenda where IDagenda=" + codeagenda;
            connexion c=new connexion();
            DataSet ds = new DataSet();
            c.getdataset(rep, "agenda", ds);

            if  ( ds.Tables["agenda"].Rows.Count!=0 )
            { 
               string pnt = ds.Tables["agenda"].Rows[0]["id_pnt"].ToString();
                this.codepnt = ds.Tables["agenda"].Rows[0]["id_pnt"].ToString(); 
                this.impactt = ds.Tables["agenda"].Rows[0]["impact"].ToString(); 
               
               
                this.scor = ds.Tables["agenda"].Rows[0]["scorimpact"].ToString();
              
                this.penalite = ds.Tables["agenda"].Rows[0]["penalite"].ToString();
             
                
                this.code = ds.Tables["agenda"].Rows[0]["IDagenda"].ToString();


                //recuperation des informations de point de controle par pnt 
                string req2 = "select * from  Table_point_de_controle where idpoint=" + pnt;
           
                DataSet dss = new DataSet();
                c.getdataset(req2, "Table_point_de_controle", dss);

                if (dss.Tables["Table_point_de_controle"].Rows.Count != 0)
                {
                 
                   
                   
                    this.categ = dss.Tables["Table_point_de_controle"].Rows[0]["categorie"].ToString();
                    this.natuure = dss.Tables["Table_point_de_controle"].Rows[0]["nature"].ToString();
                    this.pointt = dss.Tables["Table_point_de_controle"].Rows[0]["point_de_controle"].ToString();
           
                    this.structure = dss.Tables["Table_point_de_controle"].Rows[0]["structure_concernee"].ToString();
                    this.typedcontrl = dss.Tables["Table_point_de_controle"].Rows[0]["type_de_controle"].ToString();
                    this.objeet = dss.Tables["Table_point_de_controle"].Rows[0]["objet"].ToString();
                    this.textreglementaire = dss.Tables["Table_point_de_controle"].Rows[0]["type_de_regelement"].ToString();

                   }

                }


    }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void suivi2_Load(object sender, EventArgs e)
        {
            m_typereg.Text = this.textreglementaire;
            categorie.Text = this.categ ;
            nature5.Text = this.natuure;
            pd_objet.Text = this.objeet;
            pointh.Text = this.pointt;
            structureg.Text = this.structure;
            pn_conf.Text = this.penalite;
            scorea.Text = this.scor;
            impacth.Text = this.impactt;
            typev.Text = this.typedcontrl;  

            




            
        }
       
        private void chargerpointdecontrole ()
        {

        }

        private void pd_objet_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
