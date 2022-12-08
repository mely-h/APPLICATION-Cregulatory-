using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Licence
{
    public partial class planning : Form
    {
        int year, month;

        //lets create a stati variable that we can pass to another  form for month and year ;
        public static int static_month, static_year;

        public planning()
        {
            InitializeComponent();
        }

        private void planning_Load(object sender, EventArgs e)
        {
             displayDays();
        }



        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month - 1;
            year = now.Year;


            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            static_month = month;
            static_year = year;
            // lets get the first day of the month .
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            // convert the startofthemonth to integer
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // first lets create a blank usercontrol
            for (int i = 1; i < dayofweek; i++)
            {
                UserControl1 control1 = new UserControl1();
                tableLayoutPanel2.Controls.Add(control1);
            }
            //lest create d fora days
            for (int i = 1; i <= days; i++)
            {
                UserControlday controlday = new UserControlday();
                controlday.days(i);
                tableLayoutPanel2.Controls.Add(controlday);

            }
             button1_Click(null, null);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            suivant();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suivant();
        }
        private void suivant()
        {   // clear table
            tableLayoutPanel2.Controls.Clear();
            //INCREMENT  MONTH TO GO TO NExT MONTH  
            month++;
            if (month == 13) { year++; month = 1; }
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;
            DateTime now = DateTime.Now;
            // lets get the first day of the month .  
            DateTime startofthemonth = new DateTime(year, month, 1);
            // label8.Text = startofthemonth.ToString();
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startofthemonth to integer 
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // first lets create a blank usercontrol
            for (int i = 2; i < dayofweek; i++)
            {
                UserControl1 control1 = new UserControl1();
                tableLayoutPanel2.Controls.Add(control1);
            }
            //lest create d fora days
            for (int i = 1; i <= days; i++)
            {

                Panel pl = new Panel();
                pl.Dock = DockStyle.Fill;
                pl.BorderStyle= BorderStyle.FixedSingle;



                UserControlday controlday = new UserControlday();

                controlday.days(i);
               /* Label jour = new Label();
                jour.Text = i.ToString();
                */
               
                //tableLayoutPanel2.Controls.Add(controlday);


                //1- construire la date

                
                String D1;


                D1 = i.ToString() + "/" + month.ToString() + "/" + year.ToString();



                //2- selectionner les points de contôle à verifier à cette date 

                string req = "select * from agenda where statue is null and date_controle='" + D1 + "'";

                connexion c = new connexion();
                DataSet ds = new DataSet();
                c.getdataset(req, "agenda", ds);




                //3- afficher ces points de contrôle dans la case 
                for (int g = 0; g < ds.Tables["agenda"].Rows.Count; g++)
                {
                    string ag = ds.Tables["agenda"].Rows[g]["IDagenda"].ToString();
                    string pnt = ds.Tables["agenda"].Rows[g]["id_pnt"].ToString();
                    string req1 = " Select point_de_controle from Table_point_de_controle where idpoint = " + pnt+" order by idpoint desc ";
                    string pointdecontrol = c.executscalar(req1);
                    Label lb1 = new Label();
                    lb1.Dock = DockStyle.Top;
                    //lb1.DoubleClick= new EventHandler()

                    lb1.DoubleClick += new System.EventHandler(button1_DoubleClick);

                    
                    lb1.Text = ag+"- " + pointdecontrol+"\n";

                    
                    Panel lb2 = new Panel();
                    lb2.Dock = DockStyle.Top;
                    lb2.BackColor = Color.Gray;
                    lb2.Size = new Size(lb2.Width, 10);

                    //lb2.Font = new Font("Arial", 24, FontStyle.Bold);
                    pl.Controls.Add(lb2);
                    pl.Controls.Add(lb1);





                }

                // 5- construire la date suivi


                String Datesuivi_;
                 

                Datesuivi_ = i.ToString() + "/" + month.ToString() + "/" + year.ToString();





                string reqe = "select * from agenda where statue is null and date_controle='" + Datesuivi_ + "'";

                connexion con = new connexion();
                DataSet dss = new DataSet();
                c.getdataset(reqe, "agenda", dss);




                //3- afficher les suivi dans la case 
                /* for (int g = 0; g < ds.Tables["agenda"].Rows.Count; g++)
                 {
                     string pnnt = dss.Tables["agenda"].Rows[g]["IDagenda"].ToString();
                     string reqq = " Select point_de_controle from Table where IDsuivi = " + pnnt;
                     string suivi = c.executscalar(reqq);
                     lb.Text = "x" + suivi ;









                     tableLayoutPanel2.Controls.Add(lb); 
             }*/




                Label lb = new Label();

                lb.Text = i.ToString();
                lb.Dock = DockStyle.Top;
                lb.Font = new Font(lb.Font, FontStyle.Bold);
                //pl.Controls.Add(jour);

                Panel lb20 = new Panel();
                lb20.Dock = DockStyle.Top;
                lb20.Size = new Size(lb20.Width, 10);


                pl.Controls.Add(lb20); 
                
                pl.Controls.Add(lb);


                tableLayoutPanel2.Controls.Add(pl);
            }
        }
        private void button1_DoubleClick(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            string texte = btn.Text;
            int  agen = Convert.ToInt32( texte.Substring(0, texte.IndexOf("-") ));
            suivi2 sv= new suivi2(agen); 
            sv.Show();
           // MessageBox.Show("You are in the Button.DoubleClick event."+ codeagenda);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // clear table
            tableLayoutPanel2.Controls.Clear();
            //decrement   MONTH TO GO TO provious  MONTH  
            month--;
            if (month == 0)  { month = 12; year = year - 1; } 
            else {
                static_month = month;
                static_year = year;
            }
           


            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;




            DateTime now = DateTime.Now;
            // lets get the first day of the month .  

            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // convert the startofthemonth to integer
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // first lets create a blank usercontrol
            for (int i = 2; i < dayofweek; i++)
            {
                UserControl1 control1 = new UserControl1();
                tableLayoutPanel2.Controls.Add(control1);
            }
            //lest create d fora days
            for (int i = 1; i <= days; i++)
            {

                Panel pl = new Panel();
                pl.Dock = DockStyle.Fill;
                pl.BorderStyle = BorderStyle.FixedSingle;



                UserControlday controlday = new UserControlday();

                controlday.days(i);
                /* Label jour = new Label();
                 jour.Text = i.ToString();
                 */

                //tableLayoutPanel2.Controls.Add(controlday);


                //1- construire la date


                String D1;


                D1 = i.ToString() + "/" + month.ToString() + "/" + year.ToString();



                //2- selectionner les points de contôle à verifier à cette date 

                string req = "select * from agenda where statue is null and date_controle='" + D1 + "'";

                connexion c = new connexion();
                DataSet ds = new DataSet();
                c.getdataset(req, "agenda", ds);




                //3- afficher ces points de contrôle dans la case 
                for (int g = 0; g < ds.Tables["agenda"].Rows.Count; g++)
                {
                    string ag = ds.Tables["agenda"].Rows[g]["IDagenda"].ToString();
                    string pnt = ds.Tables["agenda"].Rows[g]["id_pnt"].ToString();
                    string req1 = " Select point_de_controle from Table_point_de_controle where idpoint = " + pnt + " order by idpoint desc ";
                    string pointdecontrol = c.executscalar(req1);
                    Label lb1 = new Label();
                    lb1.Dock = DockStyle.Top;
                    //lb1.DoubleClick= new EventHandler()

                    lb1.DoubleClick += new System.EventHandler(button1_DoubleClick);


                    lb1.Text = ag + "- " + pointdecontrol + "\n";


                    Panel lb2 = new Panel();
                    lb2.Dock = DockStyle.Top;
                    lb2.BackColor = Color.Gray;
                    lb2.Size = new Size(lb2.Width, 10);

                    //lb2.Font = new Font("Arial", 24, FontStyle.Bold);
                    pl.Controls.Add(lb2);
                    pl.Controls.Add(lb1);





                }

                // 5- construire la date suivi


                String Datesuivi_;


                Datesuivi_ = i.ToString() + "/" + month.ToString() + "/" + year.ToString();





                string reqe = "select * from agenda where statue is null and date_controle='" + Datesuivi_ + "'";

                connexion con = new connexion();
                DataSet dss = new DataSet();
                c.getdataset(reqe, "agenda", dss);




                //3- afficher les suivi dans la case 
                /* for (int g = 0; g < ds.Tables["agenda"].Rows.Count; g++)
                 {
                     string pnnt = dss.Tables["agenda"].Rows[g]["IDagenda"].ToString();
                     string reqq = " Select point_de_controle from Table where IDsuivi = " + pnnt;
                     string suivi = c.executscalar(reqq);
                     lb.Text = "x" + suivi ;









                     tableLayoutPanel2.Controls.Add(lb); 
             }*/




                Label lb = new Label();

                lb.Text = i.ToString();
                lb.Dock = DockStyle.Top;
                lb.Font = new Font(lb.Font, FontStyle.Bold);
                //pl.Controls.Add(jour);

                Panel lb20 = new Panel();
                lb20.Dock = DockStyle.Top;
                lb20.Size = new Size(lb20.Width, 10);


                pl.Controls.Add(lb20);

                pl.Controls.Add(lb);


                tableLayoutPanel2.Controls.Add(pl);
            }
        }

    }







 
}