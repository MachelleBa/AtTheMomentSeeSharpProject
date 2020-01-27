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
    public partial class KiesPinpasOmInTeVoeren : Form
    {
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

            dgview_pinpassenlijst.ColumnCount = 5;

            dgview_pinpassenlijst.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgview_pinpassenlijst.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview_pinpassenlijst.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgview_pinpassenlijst.Font, FontStyle.Bold);

            dgview_pinpassenlijst.Name = "dgview_pinpassenlijst";
            dgview_pinpassenlijst.Location = new Point(8, 8);
            dgview_pinpassenlijst.Size = new Size(500, 250);
            dgview_pinpassenlijst.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgview_pinpassenlijst.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dgview_pinpassenlijst.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgview_pinpassenlijst.GridColor = Color.Black;
            dgview_pinpassenlijst.RowHeadersVisible = false;

            dgview_pinpassenlijst.Columns[0].Name = "Release Date";
            dgview_pinpassenlijst.Columns[1].Name = "Track";
            dgview_pinpassenlijst.Columns[2].Name = "Title";
            dgview_pinpassenlijst.Columns[3].Name = "Artist";
            dgview_pinpassenlijst.Columns[4].Name = "Album";
            dgview_pinpassenlijst.Columns[4].DefaultCellStyle.Font =
                new Font(dgview_pinpassenlijst.DefaultCellStyle.Font, FontStyle.Italic);

            dgview_pinpassenlijst.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgview_pinpassenlijst.MultiSelect = false;
            dgview_pinpassenlijst.Dock = DockStyle.Fill;

            dgview_pinpassenlijst.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                dgview_pinpassenlijst_CellFormatting);
        }

        private void PopulateDataGridView()
        {

            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            dgview_pinpassenlijst.Rows.Add(row0);
            dgview_pinpassenlijst.Rows.Add(row1);
            dgview_pinpassenlijst.Rows.Add(row2);
            dgview_pinpassenlijst.Rows.Add(row3);
            dgview_pinpassenlijst.Rows.Add(row4);
            dgview_pinpassenlijst.Rows.Add(row5);
            dgview_pinpassenlijst.Rows.Add(row6);

            dgview_pinpassenlijst.Columns[0].DisplayIndex = 3;
            dgview_pinpassenlijst.Columns[1].DisplayIndex = 4;
            dgview_pinpassenlijst.Columns[2].DisplayIndex = 0;
            dgview_pinpassenlijst.Columns[3].DisplayIndex = 1;
            dgview_pinpassenlijst.Columns[4].DisplayIndex = 2;
        }
    }
}
