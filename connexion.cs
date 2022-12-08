using System.Data;
using System.Data.SqlClient;

namespace Licence
{
    class connexion
    {
        SqlConnection con;
        string DatabaseName = "[Cregulatory]";
        string ServerName = "LOCALHOST\\SQLEXPRESS";
        string ServerName1 = "LOCALHOST\\SQLEXPRESS";
        string BackUpFileName = "Cregulatory";
        string instanceName = "LOCALHOST";
        public static string chaineconnexion1 = "Data Source=LOCALHOST\\SQLEXPRESS ;Initial Catalog=Cregulatory ;User ID=sa;Password=amina2011; Connection Timeout=10000 ";
        public connexion()
        {

            string str = (chaineconnexion1);



            try
            {
                con = new SqlConnection(str);
                if (con.State == System.Data.ConnectionState.Closed) con.Open();

            }
            catch
            {
            }

        }
        public string executscalar(string requette)
        {   
            SqlCommand commande;
            commande = new SqlCommand(requette, con);
            var d = commande.ExecuteScalar();
            if (d == null) return "0";
            else return d.ToString();


        }

        public int GetIDexecutscalar(string requette)
        {

            SqlCommand commande;
            commande = new SqlCommand(requette, con);
            commande.CommandText = requette;
            commande.CommandType = CommandType.Text;
            commande.ExecuteNonQuery();

            SqlCommand commande2 = new SqlCommand(requette, con);
            commande2.CommandText = "select isnull(@@IDENTITY,0)";
            return Convert.ToInt32(commande2.ExecuteScalar());


        }
        public void getdataset(string req, string table, DataSet ds)
        {
            SqlDataAdapter sql = new SqlDataAdapter(req, con);
            sql.Fill(ds, table);
        }

        internal SqlCommand CreateCommande()
        {
            throw new NotImplementedException();
        }
    }


}
