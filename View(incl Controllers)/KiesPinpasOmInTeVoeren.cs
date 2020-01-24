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
    public partial class KiesPinpasOmInTeVoeren : MaterialSkin.Controls.MaterialForm
    {
        public KiesPinpasOmInTeVoeren(LoginForm loginform)
        {
            InitializeComponent();
            //Dit werkt niet :C
            Load += new EventHandler(KiesPinpasOmInTeVoeren_Load);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KiesPinpasOmInTeVoeren_Load(object sender, EventArgs e)
        {
            //Dit werkt niet :C
            DatabaseAccess db = new DatabaseAccess();

            dgview_pinpassenlijst.DataSource = db.getPinpassenLijst();
        }
    }
}
