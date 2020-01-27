using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtTheMomentSeeSharpSquad.View_incl_Controllers_
{
    public partial class transactie_overzicht : MaterialSkin.Controls.MaterialForm
    {
        public transactie_overzicht()
        {
            InitializeComponent();
        }

        private void transactie_overzicht_Load(object sender, EventArgs e)
        {
            string sourceItem = AppDomain.CurrentDomain.BaseDirectory + "Database_SeeSharpSquad_ATM.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + sourceItem);

            {
                //binnen sql commando moet straks de klantnummer dynamisch zijn aan de hand van de ingelogde gebruiker!
                using (SqlCommand cmd = new SqlCommand("SELECT transactieID, transactionDoneBy, sourceBetaalrekening, destinationBetaalrekening, date FROM Transactie WHERE transactieID = 1;"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        lb_transactie_idTxt.Text = sdr["transactieID"].ToString();
                        lb_transactie_door.Text = sdr["transactionDoneBy"].ToString();
                        lb_van_betaalrekeningTxt.Text = sdr["sourceBetaalrekening"].ToString();
                        lb_naar_betaalrekeningTxt.Text = sdr["destinationBetaalrekening"].ToString();
                        lb_datumTxt.Text = sdr["date"].ToString();
                    }
                    con.Close();
                }
            }
        }

        private void lb_transactie_doorTxt_Click(object sender, EventArgs e)
        {

        }

        private void lb_transactie_idTxt_Click(object sender, EventArgs e)
        {

        }

        private void lb_transactie_door_Click(object sender, EventArgs e)
        {

        }

        private void lb_transactie_id_Click(object sender, EventArgs e)
        {

        }
    }
}
