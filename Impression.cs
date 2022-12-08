namespace Licence
{
    public partial class Impression : Form
    {
        public Impression(string filePath)
        {
            InitializeComponent();

            webBrowser1.Navigate(@filePath);
        }

        private void Impression_Load(object sender, EventArgs e)
        {

        }
    }
}
