namespace ADV
{
    partial class Register
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
            this.Register_Password = new Guna.UI2.WinForms.Guna2Button();
            this.Password_Reg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserId_Reg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Register_User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register_Password
            // 
            this.Register_Password.BorderRadius = 15;
            this.Register_Password.CheckedState.Parent = this.Register_Password;
            this.Register_Password.CustomImages.Parent = this.Register_Password;
            this.Register_Password.FillColor = System.Drawing.Color.CadetBlue;
            this.Register_Password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Password.ForeColor = System.Drawing.Color.White;
            this.Register_Password.HoverState.Parent = this.Register_Password;
            this.Register_Password.Location = new System.Drawing.Point(67, 299);
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.ShadowDecoration.Parent = this.Register_Password;
            this.Register_Password.Size = new System.Drawing.Size(180, 45);
            this.Register_Password.TabIndex = 8;
            this.Register_Password.Text = "REGISTER";
            this.Register_Password.Click += new System.EventHandler(this.Register_Password_Click);
            // 
            // Password_Reg
            // 
            this.Password_Reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Reg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_Reg.ForeColor = System.Drawing.Color.CadetBlue;
            this.Password_Reg.HintForeColor = System.Drawing.Color.Empty;
            this.Password_Reg.HintText = "";
            this.Password_Reg.isPassword = true;
            this.Password_Reg.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.Password_Reg.LineIdleColor = System.Drawing.Color.Gray;
            this.Password_Reg.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.Password_Reg.LineThickness = 3;
            this.Password_Reg.Location = new System.Drawing.Point(26, 202);
            this.Password_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Reg.Name = "Password_Reg";
            this.Password_Reg.Size = new System.Drawing.Size(292, 44);
            this.Password_Reg.TabIndex = 7;
            this.Password_Reg.Text = "Password";
            this.Password_Reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserId_Reg
            // 
            this.UserId_Reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserId_Reg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserId_Reg.ForeColor = System.Drawing.Color.CadetBlue;
            this.UserId_Reg.HintForeColor = System.Drawing.Color.Empty;
            this.UserId_Reg.HintText = "";
            this.UserId_Reg.isPassword = false;
            this.UserId_Reg.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.UserId_Reg.LineIdleColor = System.Drawing.Color.Gray;
            this.UserId_Reg.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.UserId_Reg.LineThickness = 3;
            this.UserId_Reg.Location = new System.Drawing.Point(26, 121);
            this.UserId_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.UserId_Reg.Name = "UserId_Reg";
            this.UserId_Reg.Size = new System.Drawing.Size(292, 44);
            this.UserId_Reg.TabIndex = 6;
            this.UserId_Reg.Text = "User Id";
            this.UserId_Reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Register_User
            // 
            this.Register_User.AutoSize = true;
            this.Register_User.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_User.ForeColor = System.Drawing.Color.CadetBlue;
            this.Register_User.Location = new System.Drawing.Point(86, 38);
            this.Register_User.Name = "Register_User";
            this.Register_User.Size = new System.Drawing.Size(161, 42);
            this.Register_User.TabIndex = 5;
            this.Register_User.Text = "Register";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 388);
            this.Controls.Add(this.Register_Password);
            this.Controls.Add(this.Password_Reg);
            this.Controls.Add(this.UserId_Reg);
            this.Controls.Add(this.Register_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Register_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_Reg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserId_Reg;
        private System.Windows.Forms.Label Register_User;
    }
}