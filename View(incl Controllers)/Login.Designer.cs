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
            this.sql_test_label_loginForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom, Log in om te beginnen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_voer_pas_in
            // 
            this.btn_voer_pas_in.Location = new System.Drawing.Point(301, 175);
            this.btn_voer_pas_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voer_pas_in.Name = "btn_voer_pas_in";
            this.btn_voer_pas_in.Size = new System.Drawing.Size(155, 33);
            this.btn_voer_pas_in.TabIndex = 1;
            this.btn_voer_pas_in.Text = "Voer pinpas in";
            this.btn_voer_pas_in.UseVisualStyleBackColor = true;
            this.btn_voer_pas_in.Click += new System.EventHandler(this.btn_voer_pas_in_Click);
            // 
            // sql_test_label_loginForm
            // 
            this.sql_test_label_loginForm.AutoSize = true;
            this.sql_test_label_loginForm.BackColor = System.Drawing.Color.Transparent;
            this.sql_test_label_loginForm.Location = new System.Drawing.Point(284, 265);
            this.sql_test_label_loginForm.Name = "sql_test_label_loginForm";
            this.sql_test_label_loginForm.Size = new System.Drawing.Size(28, 17);
            this.sql_test_label_loginForm.TabIndex = 2;
            this.sql_test_label_loginForm.Text = "     ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sql_test_label_loginForm);
            this.Controls.Add(this.btn_voer_pas_in);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "SeeSharpSquad - ATM";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voer_pas_in;
        private System.Windows.Forms.Label sql_test_label_loginForm;
    }
}

