using AtTheMomentSeeSharpSquad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtTheMomentSeeSharpSquad.View_incl_Controllers_
{
    public partial class CashWithdraw : MaterialSkin.Controls.MaterialForm
    {

        private Gebruiker gebruiker;
        private LoginForm loginForm;

        public CashWithdraw(Model.Gebruiker gebruiker, LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.gebruiker = gebruiker;

            DatabaseAccess db = new DatabaseAccess();

            InitializeComponent();
            lbl_naam.Text = "";
            lbl_naam.Text = gebruiker.getVoornaam();
            lbl_rekeningNr.Text = "";
            lbl_rekeningNr.Text = gebruiker.getRekeningNummer();
            lbl_saldo.Text = "";
            lbl_saldo.Text = "€ " + db.haalSaldoOP(gebruiker).ToString("0.##");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_account_info_Click(object sender, EventArgs e)
        {
            Account_Overzicht accountForm = new Account_Overzicht(gebruiker, this);
            accountForm.Show();
            this.Hide();

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.loginForm.Show();
            this.Hide();
        }
    }
}
