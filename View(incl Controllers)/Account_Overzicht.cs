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

namespace AtTheMomentSeeSharpSquad.View_incl_Controllers_
{
    public partial class Account_Overzicht : MaterialSkin.Controls.MaterialForm
    {
        public Account_Overzicht()
        {
            InitializeComponent();
        }

        private void Account_Overzicht_Load(object sender, EventArgs e)
        {
            string sourceItem = AppDomain.CurrentDomain.BaseDirectory + "Database_SeeSharpSquad_ATM.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourceItem);

            {
                //binnen sql commando moet straks de klantnummer dynamisch zijn aan de hand van de ingelogde gebruiker!
                using (SqlCommand cmd = new SqlCommand("SELECT KlantNummer, LastName, FirstName, BirthDate, RekeningNummer FROM Klant WHERE KlantNummer = 1"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        lb_klantnummerTxt.Text = sdr["KlantNummer"].ToString();
                        lb_voornaamTxt.Text = sdr["FirstName"].ToString();
                        lb_achternaamTxt.Text = sdr["LastName"].ToString();
                        lb_geboortedatumTxt.Text = sdr["BirthDate"].ToString();
                        lb_rekeningnummerTxt.Text = sdr["RekeningNummer"].ToString();
                    }
                    con.Close();
                }
            }
        }
    }
}
