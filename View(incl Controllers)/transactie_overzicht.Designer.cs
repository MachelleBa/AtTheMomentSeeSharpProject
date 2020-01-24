namespace AtTheMomentSeeSharpSquad.View_incl_Controllers_
{
    partial class transactie_overzicht
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
            this.lb_naar_betaalrekening = new MaterialSkin.Controls.MaterialLabel();
            this.lb_van_betaalrekening = new MaterialSkin.Controls.MaterialLabel();
            this.lb_transactie_door = new MaterialSkin.Controls.MaterialLabel();
            this.lb_transactie_id = new MaterialSkin.Controls.MaterialLabel();
            this.lb_datum = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lb_naar_betaalrekening
            // 
            this.lb_naar_betaalrekening.AutoSize = true;
            this.lb_naar_betaalrekening.Depth = 0;
            this.lb_naar_betaalrekening.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_naar_betaalrekening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_naar_betaalrekening.Location = new System.Drawing.Point(515, 92);
            this.lb_naar_betaalrekening.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_naar_betaalrekening.Name = "lb_naar_betaalrekening";
            this.lb_naar_betaalrekening.Size = new System.Drawing.Size(143, 19);
            this.lb_naar_betaalrekening.TabIndex = 1;
            this.lb_naar_betaalrekening.Text = "Naar betaalrekening";
            // 
            // lb_van_betaalrekening
            // 
            this.lb_van_betaalrekening.AutoSize = true;
            this.lb_van_betaalrekening.Depth = 0;
            this.lb_van_betaalrekening.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_van_betaalrekening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_van_betaalrekening.Location = new System.Drawing.Point(340, 92);
            this.lb_van_betaalrekening.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_van_betaalrekening.Name = "lb_van_betaalrekening";
            this.lb_van_betaalrekening.Size = new System.Drawing.Size(137, 19);
            this.lb_van_betaalrekening.TabIndex = 2;
            this.lb_van_betaalrekening.Text = "Van betaalrekening";
            // 
            // lb_transactie_door
            // 
            this.lb_transactie_door.AutoSize = true;
            this.lb_transactie_door.Depth = 0;
            this.lb_transactie_door.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_transactie_door.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_transactie_door.Location = new System.Drawing.Point(187, 92);
            this.lb_transactie_door.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_transactie_door.Name = "lb_transactie_door";
            this.lb_transactie_door.Size = new System.Drawing.Size(115, 19);
            this.lb_transactie_door.TabIndex = 3;
            this.lb_transactie_door.Text = "Transactie door";
            // 
            // lb_transactie_id
            // 
            this.lb_transactie_id.AutoSize = true;
            this.lb_transactie_id.Depth = 0;
            this.lb_transactie_id.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_transactie_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_transactie_id.Location = new System.Drawing.Point(55, 92);
            this.lb_transactie_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_transactie_id.Name = "lb_transactie_id";
            this.lb_transactie_id.Size = new System.Drawing.Size(94, 19);
            this.lb_transactie_id.TabIndex = 4;
            this.lb_transactie_id.Text = "TransactieID";
            // 
            // lb_datum
            // 
            this.lb_datum.AutoSize = true;
            this.lb_datum.Depth = 0;
            this.lb_datum.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_datum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_datum.Location = new System.Drawing.Point(696, 92);
            this.lb_datum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_datum.Name = "lb_datum";
            this.lb_datum.Size = new System.Drawing.Size(53, 19);
            this.lb_datum.TabIndex = 5;
            this.lb_datum.Text = "Datum";
            // 
            // transactie_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_datum);
            this.Controls.Add(this.lb_naar_betaalrekening);
            this.Controls.Add(this.lb_van_betaalrekening);
            this.Controls.Add(this.lb_transactie_door);
            this.Controls.Add(this.lb_transactie_id);
            this.Name = "transactie_overzicht";
            this.Text = "Transactie overzicht";
            this.Load += new System.EventHandler(this.transactie_overzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lb_naar_betaalrekening;
        private MaterialSkin.Controls.MaterialLabel lb_van_betaalrekening;
        private MaterialSkin.Controls.MaterialLabel lb_transactie_door;
        private MaterialSkin.Controls.MaterialLabel lb_transactie_id;
        private MaterialSkin.Controls.MaterialLabel lb_datum;
    }
}