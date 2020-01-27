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
        private DataGridView dgview_pinpassenlijst = new DataGridView();
        public KiesPinpasOmInTeVoeren(LoginForm loginform)
        {
            InitializeComponent();
            SetUpDataGridView();
            PopulateDataGridView();

        }

        private void dgview_pinpassenlijst_CellFormatting(object sender,
    System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.dgview_pinpassenlijst.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }
        private void SetUpDataGridView()
        {
            this.Controls.Add(dgview_pinpassenlijst);

            dgview_pinpassenlijst.ColumnCount = 3;

            dgview_pinpassenlijst.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgview_pinpassenlijst.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview_pinpassenlijst.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgview_pinpassenlijst.Font, FontStyle.Bold);

                dgview_pinpassenlijst.Name = "dgview_pinpassenlijst";
                dgview_pinpassenlijst.Location = new Point(30, 100);
                dgview_pinpassenlijst.Size = new Size(500, 250);
                dgview_pinpassenlijst.AutoSizeRowsMode =
                   DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgview_pinpassenlijst.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgview_pinpassenlijst.ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.Single;
                dgview_pinpassenlijst.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgview_pinpassenlijst.GridColor = Color.Black;
                dgview_pinpassenlijst.RowHeadersVisible = false;

                dgview_pinpassenlijst.Columns[0].Name = "Rekening Nummer";
                dgview_pinpassenlijst.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgview_pinpassenlijst.Columns[1].Name = "Pas Nummer";
                dgview_pinpassenlijst.Columns[2].Name = "Klant";


                dgview_pinpassenlijst.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgview_pinpassenlijst.MultiSelect = false;
            dgview_pinpassenlijst.CellClick += new DataGridViewCellEventHandler(this.dgview_pinpassenlijst_CellClick);

            dgview_pinpassenlijst.CellFormatting += new
                    DataGridViewCellFormattingEventHandler(
                    dgview_pinpassenlijst_CellFormatting);
        }
        private void dgview_pinpassenlijst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgview_pinpassenlijst.Rows[index];
            string rekeningNummer = selectedRow.Cells[0].Value.ToString();
            int pasNummer = Int32.Parse(selectedRow.Cells[1].Value.ToString());
            string klantNaam = selectedRow.Cells[2].Value.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

            private void PopulateDataGridView()
            {
            DatabaseAccess db = new DatabaseAccess();
            List<Gebruiker> login_list = db.getLoginOpties();


            foreach (Gebruiker gebruiker in login_list)
            {
                string[] temp = { gebruiker.getRekeningNummer(), gebruiker.getVoornaam() + " " + gebruiker.getAchternaam(), gebruiker.getPasNummer().ToString() };
                dgview_pinpassenlijst.Rows.Add(temp);

                materialLabel2.Text += gebruiker.getRekeningNummer() + "/n";
            }
            //string[] row0 = { "11/22/1968", "29", "Revolution 9" };
            //string[] row1 = { "1960", "6", "Fools Rush In" };
            //string[] row2 = { "11/11/1971", "1", "One of These Days" };
            //string[] row3 = { "1988", "7", "Where Is My Mind?" };
            //string[] row4 = { "5/1981", "9", "Can't Find My Mind" };
            //string[] row5 = { "6/10/2003", "13",
            //        "Scatterbrain. (As Dead As Leaves.)"
            //         };
            //string[] row6 = { "6/30/1992", "3", "Dress" };


            //dgview_pinpassenlijst.Rows.Add(row1);
            //dgview_pinpassenlijst.Rows.Add(row2);
            //dgview_pinpassenlijst.Rows.Add(row3);
            //dgview_pinpassenlijst.Rows.Add(row4);
            //dgview_pinpassenlijst.Rows.Add(row5);
            //dgview_pinpassenlijst.Rows.Add(row6);

            dgview_pinpassenlijst.Columns[0].DisplayIndex = 0;
            dgview_pinpassenlijst.Columns[1].DisplayIndex = 1;
            dgview_pinpassenlijst.Columns[2].DisplayIndex = 2;


        }
    }
}
