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
            label1.Text = "I've changed. It's not you, it's me";
        }

        private void btn_voer_pas_in_Click(object sender, EventArgs e)
        {
            KiesPinpasOmInTeVoeren kiesPinpasForm = new KiesPinpasOmInTeVoeren();
        }
    }
}
