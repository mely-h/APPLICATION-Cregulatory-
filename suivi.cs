using System.Data;

namespace Licence
{
    public partial class suivi : Form
    {
        public suivi()
        {
            InitializeComponent();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void suivi_Load(object sender, EventArgs e)
        {
            charger_les_suivis();
        }
        private void charger_les_suivis()
        {
            connexion co = new connexion();
            DataSet ds = new DataSet();

            string req = "select T.type_de_regelement as Textregelment ,T.objet as objet  , T.categorie as categorie , T.point_de_controle as pointdecontrole , T.structure_concernee as structureconcernee , T.limpact as impact , T.nature as nature , T.type_de_controle as typeControle , T.penality as penalite  , A.date_controle from  agenda A, Table_point_de_controle T " +
             " where  T.idpoint = A.id_pnt and " +
              "id_source is not null and statue is null ";

            co.getdataset(req, "[Table_point_de_controle]", ds);
            dg_affichage.AutoGenerateColumns = true;
            dg_affichage.DataSource = ds;
            dg_affichage.DataMember = "[Table_point_de_controle]";


        }


    }
}
