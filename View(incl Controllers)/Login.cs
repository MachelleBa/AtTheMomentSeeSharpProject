using AtTheMomentSeeSharpSquad.Model;
using AtTheMomentSeeSharpSquad.View_incl_Controllers_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtTheMomentSeeSharpSquad
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            //hier nooit iets voor zetten! dit moet altijd als eerste!
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "It's not you, it's me: I've changed.";
        }

        private void btn_voer_pas_in_Click(object sender, EventArgs e)
        {
     
            KiesPinpasOmInTeVoeren kiesPinpasForm = new KiesPinpasOmInTeVoeren(this);
            kiesPinpasForm.Show();
            this.Hide();
        }

        public void PrintPinpassenLijstInLabel()
        {
            DatabaseAccess db = new DatabaseAccess();
            List<Pinpas> pinpassenlijst = db.getPinpassenLijst();

            foreach (Pinpas pinpas in pinpassenlijst)
            {
               sql_test_label_loginForm.Text+= "pasnummer: " + pinpas.getPasNummer().ToString() + "  vervalDatum: " + pinpas.getVervalDatum().ToString()+ "\n";

            }




        }
    }
}
