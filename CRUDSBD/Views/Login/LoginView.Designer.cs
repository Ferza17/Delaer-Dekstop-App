namespace CRUDSBD.Views {
    partial class LoginView {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.SignUp = new System.Windows.Forms.Label();
            this.panelSignin = new System.Windows.Forms.Panel();
            this.Signin = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelSignup.SuspendLayout();
            this.panelSignin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelSignup);
            this.panel2.Controls.Add(this.panelSignin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 514);
            this.panel2.TabIndex = 0;
            // 
            // panelSignup
            // 
            this.panelSignup.BackColor = System.Drawing.Color.SlateGray;
            this.panelSignup.Controls.Add(this.SignUp);
            this.panelSignup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSignup.Location = new System.Drawing.Point(0, 241);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(200, 273);
            this.panelSignup.TabIndex = 0;
            this.panelSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(37, 114);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(117, 37);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign Up";
            this.SignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUp.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelSignin
            // 
            this.panelSignin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSignin.Controls.Add(this.Signin);
            this.panelSignin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSignin.Location = new System.Drawing.Point(0, 0);
            this.panelSignin.Name = "panelSignin";
            this.panelSignin.Size = new System.Drawing.Size(200, 241);
            this.panelSignin.TabIndex = 0;
            this.panelSignin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Signin
            // 
            this.Signin.AutoSize = true;
            this.Signin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin.Location = new System.Drawing.Point(37, 99);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(105, 37);
            this.Signin.TabIndex = 0;
            this.Signin.Text = "Sign In";
            this.Signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Signin.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 100);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(769, 514);
            this.mainpanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Apps";
            // 
            // LoginIseng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 614);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginIseng";
            this.Text = "Dealer Apps";
            this.panel2.ResumeLayout(false);
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            this.panelSignin.ResumeLayout(false);
            this.panelSignin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.Panel panelSignin;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Label Signin;
    }
}