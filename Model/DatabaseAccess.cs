using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheMomentSeeSharpSquad.Model
{
    class DatabaseAccess
    {
        //connection string
        // Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\machelle\Documents\Young Capital NEXT HBO\C# keuzevak\AtTheMomentSeeSharpProject\Database_SeeSharpSquad_ATM.mdf";Integrated Security = True
        // Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Gberuikers\sbouz\Documents\Keuzevak\AtTheMomentSeeSharpProject\Database_SeeSharpSquad_ATM.mdf";Integrated Security = True

        private SqlConnection OpenConnDB() //Machelle
        {
            try
            {
                string sourceItem = AppDomain.CurrentDomain.BaseDirectory + "Database_SeeSharpSquad_ATM.mdf; Integrated Security = True";

                SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourceItem);


                sqlconn.Open();

                return sqlconn;

            }
            catch (SqlException e)
            {
                SqlConnection sqlconn = null;
                //exception message needs to be passed to logic layer here
                return sqlconn;
            }
        }
        private void CloseConnDB(SqlConnection sqlconn) //Machelle
        {
            sqlconn.Close();
        }

        public List<Pinpas> getPinpassenLijst()
        {
            SqlConnection conn = OpenConnDB();
            List<Pinpas> pinpas_list = new List<Pinpas>();

            string query = "SELECT PasNummer, VervalDatum FROM Pinpas";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Pinpas pinpas = new Pinpas(Int32.Parse(reader["PasNummer"].ToString()), DateTime.Parse((reader["VervalDatum"].ToString())));
                pinpas_list.Add(pinpas);
            }

            CloseConnDB(conn);
            return pinpas_list;

        }

        //Om de lijst met pinpassen weer te kunnen geven
        public List<Gebruiker> getLoginOpties() { 
        
            List<Gebruiker> login_list = new List<Gebruiker>();

            SqlConnection conn = OpenConnDB();
            string query = "SELECT RekeningNummer, FirstName, LastName, PasNummer FROM Klant INNER JOIN Pinpas ON Klant.PinpasID = Pinpas.PinpasId";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Gebruiker gebruiker = new Gebruiker(reader["RekeningNummer"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), Int32.Parse(reader["PasNummer"].ToString()));
                login_list.Add(gebruiker);
            }

            CloseConnDB(conn);

            return login_list;

        }



    }
}