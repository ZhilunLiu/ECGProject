namespace ECGProject
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.labofUsr = new System.Windows.Forms.Label();
            this.labofPsw = new System.Windows.Forms.Label();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labofUsr
            // 
            this.labofUsr.AutoSize = true;
            this.labofUsr.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labofUsr.Location = new System.Drawing.Point(39, 354);
            this.labofUsr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labofUsr.Name = "labofUsr";
            this.labofUsr.Size = new System.Drawing.Size(227, 60);
            this.labofUsr.TabIndex = 0;
            this.labofUsr.Text = "Username";
            this.labofUsr.Click += new System.EventHandler(this.label1_Click);
            // 
            // labofPsw
            // 
            this.labofPsw.AutoSize = true;
            this.labofPsw.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labofPsw.Location = new System.Drawing.Point(50, 443);
            this.labofPsw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labofPsw.Name = "labofPsw";
            this.labofPsw.Size = new System.Drawing.Size(217, 60);
            this.labofPsw.TabIndex = 1;
            this.labofPsw.Text = "Password";
            // 
            // txtUsrName
            // 
            this.txtUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrName.Location = new System.Drawing.Point(298, 358);
            this.txtUsrName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(260, 53);
            this.txtUsrName.TabIndex = 2;
            this.txtUsrName.TextChanged += new System.EventHandler(this.txtUsrName_TextChanged);
            // 
            // txtPsw
            // 
            this.txtPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsw.Location = new System.Drawing.Point(298, 448);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(260, 53);
            this.txtPsw.TabIndex = 3;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 351);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(98, 558);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(186, 78);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(375, 558);
            this.btnreg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(186, 78);
            this.btnreg.TabIndex = 6;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 692);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUsrName);
            this.Controls.Add(this.labofPsw);
            this.Controls.Add(this.labofUsr);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labofUsr;
        private System.Windows.Forms.Label labofPsw;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnreg;
    }
}

