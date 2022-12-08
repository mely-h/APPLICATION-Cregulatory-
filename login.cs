namespace Licence
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connexion con = new connexion();
            string req = " select isnull( IDusers,0) from Table_users where username='" + username.Text + "' and password='" + password.Text+"'";
            string id=con.executscalar(req);
            if (id == "")
            {
                id = "0"; 
            }


            if (Convert.ToInt32(id) != 0)
            {

                menu start = new menu();
                start.Show();

            }
            else
            {
             if(username.Text!="" &&   password.Text!="")
                    MessageBox.Show("Username || Password incorrect !");

                username.Text = "";
                password.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register regis = new register();
            regis.Show();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       /* private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                password.UseSystemPasswordChar =false;
            else 
                password.UseSystemPasswordChar =true;
        }*/

        private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
