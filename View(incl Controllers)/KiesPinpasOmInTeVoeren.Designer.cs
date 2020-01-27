using AtTheMomentSeeSharpSquad.Model;

namespace AtTheMomentSeeSharpSquad.View_incl_Controllers_
{
    partial class KiesPinpasOmInTeVoeren
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgview_pinpassenlijst = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_pinpassenlijst)).BeginInit();
            this.SuspendLayout();

            // 
            // dgview_pinpassenlijst
            // 
            this.dgview_pinpassenlijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_pinpassenlijst.Location = new System.Drawing.Point(98, 73);
            this.dgview_pinpassenlijst.Name = "dgview_pinpassenlijst";
            this.dgview_pinpassenlijst.RowHeadersWidth = 51;
            this.dgview_pinpassenlijst.RowTemplate.Height = 24;
            this.dgview_pinpassenlijst.Size = new System.Drawing.Size(509, 194);
            this.dgview_pinpassenlijst.TabIndex = 2;
            // 
            // KiesPinpasOmInTeVoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.dgview_pinpassenlijst);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KiesPinpasOmInTeVoeren";
            this.Text = "KiesPinpasOmInTeVoeren";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_pinpassenlijst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgview_pinpassenlijst;
    }
}