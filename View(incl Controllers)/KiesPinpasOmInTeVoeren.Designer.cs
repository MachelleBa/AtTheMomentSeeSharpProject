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
            this.dgview_KiesPinpas = new System.Windows.Forms.DataGridView();
            this.RekeningNummer_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasNummer_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voornaam_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Achternaam_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_KiesPinpas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview_KiesPinpas
            // 
            this.dgview_KiesPinpas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_KiesPinpas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RekeningNummer_Col,
            this.PasNummer_Col,
            this.Voornaam_Col,
            this.Achternaam_Col});
            this.dgview_KiesPinpas.Location = new System.Drawing.Point(50, 58);
            this.dgview_KiesPinpas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgview_KiesPinpas.Name = "dgview_KiesPinpas";
            this.dgview_KiesPinpas.RowHeadersWidth = 62;
            this.dgview_KiesPinpas.RowTemplate.Height = 28;
            this.dgview_KiesPinpas.Size = new System.Drawing.Size(592, 244);
            this.dgview_KiesPinpas.TabIndex = 0;
            // 
            // RekeningNummer_Col
            // 
            this.RekeningNummer_Col.HeaderText = "RekeningNummer";
            this.RekeningNummer_Col.MinimumWidth = 8;
            this.RekeningNummer_Col.Name = "RekeningNummer_Col";
            this.RekeningNummer_Col.Width = 150;
            // 
            // PasNummer_Col
            // 
            this.PasNummer_Col.HeaderText = "PasNummer";
            this.PasNummer_Col.MinimumWidth = 8;
            this.PasNummer_Col.Name = "PasNummer_Col";
            this.PasNummer_Col.Width = 150;
            // 
            // Voornaam_Col
            // 
            this.Voornaam_Col.HeaderText = "Voornaam";
            this.Voornaam_Col.MinimumWidth = 8;
            this.Voornaam_Col.Name = "Voornaam_Col";
            this.Voornaam_Col.Width = 150;
            // 
            // Achternaam_Col
            // 
            this.Achternaam_Col.HeaderText = "Achternaam";
            this.Achternaam_Col.MinimumWidth = 8;
            this.Achternaam_Col.Name = "Achternaam_Col";
            this.Achternaam_Col.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kies een pinpas om in te voeren";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KiesPinpasOmInTeVoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgview_KiesPinpas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KiesPinpasOmInTeVoeren";
            this.Text = "KiesPinpasOmInTeVoeren";
            ((System.ComponentModel.ISupportInitialize)(this.dgview_KiesPinpas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgview_KiesPinpas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RekeningNummer_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasNummer_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voornaam_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Achternaam_Col;
        private System.Windows.Forms.Label label1;
    }
}