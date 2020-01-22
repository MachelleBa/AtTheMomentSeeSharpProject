namespace AtTheMomentSeeSharpSquad
{
    partial class LoginForm
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
            this.btn_voer_pas_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom, Log in om te beginnen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_voer_pas_in
            // 
            this.btn_voer_pas_in.Location = new System.Drawing.Point(326, 129);
            this.btn_voer_pas_in.Name = "btn_voer_pas_in";
            this.btn_voer_pas_in.Size = new System.Drawing.Size(174, 41);
            this.btn_voer_pas_in.TabIndex = 1;
            this.btn_voer_pas_in.Text = "Voer pinpas in";
            this.btn_voer_pas_in.UseVisualStyleBackColor = true;
            this.btn_voer_pas_in.Click += new System.EventHandler(this.btn_voer_pas_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btn_voer_pas_in);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SeeSharpSquad - ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voer_pas_in;
    }
}

