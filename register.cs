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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) 
        {
            string id_users = Nvutilisateur();

        }
        private string Nvutilisateur () 
       {
        if (username1.Text == "" || password1.Text == "") { 
                MessageBox.Show("merci de remplir les champs obligatoires");
            return "-1";
        }
            else

            {

                string nom = "";
                string prenom = "";
                string email = "";
                string username = "";
                string password = "";
                
                nom = nom1.Text.Replace("' ", "'");
                prenom = prenom1.Text.Replace("' ", "'");
                email = email1.Text.Replace("' ", "'");
                username = username1.Text.Replace("' ", "'");
                password = password1.Text.Replace("' ", "'");
               


                connexion con = new connexion();
                string req = "INSERT INTO[Cregulatory].[dbo].[Table_users]" +
                " ([nom]," +
                " [prenom]," +
                " [mail]," +
                " [username]," +
                " [password])" +

                "   VALUES (" +
                " '" + nom + "'," +
                " '" + prenom + "'," +
                " '" + email + "'," +
                " '" + username + "'," +
                " '" + password + "')";

               
                string d =con.executscalar (req);
                MessageBox.Show("register successfully");
                return d;   
               
            }
        }
       private void button2_Click(object sender, EventArgs e)
        {
           /* login log = new login();
            log.Show();*/
        }

        private void register_Load_2(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prenom1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}































































