using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licence
{
    public partial class Agenda : Form

    {
        int year, month;

        //lets create a stati variable that we can pass to another  form for month and year ;
        public static int static_month, static_year;



        public Agenda()
        {
            InitializeComponent();
        }



        private void Agenda_Load(object sender, EventArgs e)

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
                tableLayoutPanel1.Controls.Add(control1);
            }
            //lest create d fora days
            for (int i = 1; i <= days; i++)
            {
                UserControlday controlday = new UserControlday();
                controlday.days(i);
                tableLayoutPanel1.Controls.Add(controlday);
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
            tableLayoutPanel1.Controls.Clear();
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
                tableLayoutPanel1.Controls.Add(control1);
            }
            //lest create d fora days
            for (int i = 1; i <= days; i++)
            {

                Panel pl = new Panel();
                pl.Dock = DockStyle.Fill;    



                UserControlday controlday = new UserControlday();

                controlday.days(i);
                Label jour = new Label();
                jour.Text = i.ToString();   

                Label lb = new Label();

                lb.Text = i.ToString()+"bonjour";
                //pl.Controls.Add(jour);
                pl.Controls.Add(lb);



                //1- construire la date


                String D1; 


                 D1= i.ToString() + "/" + month.ToString() + "/" + year.ToString();



                //2- selectionner les points de contôle à verifier à cette date 

                string req = "select * from agenda where date_controle='" + D1 + "'";

                connexion c = new connexion();
                DataSet ds = new DataSet();
                c.getdataset(req, "agenda", ds); 




                //3- afficher ces points de contrôle dans la case 
                for (int g = 0; g < ds.Tables["agenda"].Rows.Count; g++) {
                    string pnt = ds.Tables["agenda"].Rows[g]["id_pnt"].ToString();
                    string req1 = " Select point_de_controle from Table_point_de_controle where idpoint = "+pnt;
                    string pointdecontrol= c.executscalar(req1); 
                    lb.Text = "x"+pointdecontrol; 

                  
                
                }
                
               // 5- construire la date suivi


                String Datesuivi_;


                Datesuivi_ = i.ToString() + "/" + month.ToString() + "/" + year.ToString();



                 

                string reqe = "select * from agenda where date_controle='" + Datesuivi_ + "'";

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
                








                    tableLayoutPanel1.Controls.Add(lb); 
            }*/
        }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear table
            tableLayoutPanel1.Controls.Clear();
            //decrement   MONTH TO GO TO provious  MONTH  
            month--;
            static_month = month;
            static_year = year;


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
                tableLayoutPanel1.Controls.Add(control1);
            }
            //lest create d fora days
            for (int i = 1; i <= days; i++)
            {
                UserControlday controlday = new UserControlday();
                controlday.days(i);
                tableLayoutPanel1.Controls.Add(controlday);
            }
        }







    }
}

