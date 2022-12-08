
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
    public partial class UserControlday : UserControl
    {
        String connString = "Data Source=LOCALHOST\\SQLEXPRESS ;Initial Catalog=Cregulatory ;User ID=sa;Password=amina2011; Connection Timeout=10000 ";

        //let us create another static variable for days ; 
        public static string static_days;
        public UserControlday()
        {
            InitializeComponent();
        }

        private void UserControlday_Load(object sender, EventArgs e)
        {
           
        }
        public void days(int numday)
        {
            label1.Text = numday + "";
        }

        private void UserControlday_Click(object sender, EventArgs e)
        {
            static_days = label1.Text;
            //start timer if usercontroldays is click 
            timer1.Start();
            pntControle pntcontroole = new pntControle();
            pntcontroole.Show();
        }


        // create a new method to diplay point 
        private void displayControl()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM dbo.agenda where date =? ";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", Agenda.static_month + "-" + Agenda.static_year + "-" + label1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {

                ibptn.Text = reader["point de controle"].ToString();

            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

        }
        //create a timer for auto display control if new control add 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //call the display method 
            displayControl();
        }
        







    }
}
