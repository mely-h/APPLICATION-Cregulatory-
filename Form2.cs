namespace Licence
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connexion c = new connexion();
            string req = " Insert into Structures ( nom_structure  ,email_structure ) values('" + nom.Text + "' , '" + mail.Text + "')";
            c.executscalar(req);
            MessageBox.Show("structure enregistré!");
            this.Close();
        }
    }
}
