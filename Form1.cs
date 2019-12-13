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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //hier nooit iets voor zetten! dit moet altijd als eerste!
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "I've changed, it's me not you"; 
        }
    }
}
