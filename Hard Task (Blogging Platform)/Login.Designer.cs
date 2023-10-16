namespace ADV
{
    partial class Login
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
            this.Register_Login = new System.Windows.Forms.LinkLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // Register_Login
            // 
            this.Register_Login.AutoSize = true;
            this.Register_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Login.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Login.LinkColor = System.Drawing.Color.CadetBlue;
            this.Register_Login.Location = new System.Drawing.Point(137, 352);
            this.Register_Login.Name = "Register_Login";
            this.Register_Login.Size = new System.Drawing.Size(68, 16);
            this.Register_Login.TabIndex = 8;
            this.Register_Login.TabStop = true;
            this.Register_Login.Text = "Register";
            this.Register_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_Login_LinkClicked);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.CadetBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(78, 281);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "LOGIN";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.CadetBlue;
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = true;
            this.Password.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(26, 201);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(292, 44);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.Password_OnValueChanged);
            // 
            // UserId
            // 
            this.UserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserId.ForeColor = System.Drawing.Color.CadetBlue;
            this.UserId.HintForeColor = System.Drawing.Color.Empty;
            this.UserId.HintText = "";
            this.UserId.isPassword = false;
            this.UserId.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.UserId.LineIdleColor = System.Drawing.Color.Gray;
            this.UserId.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.UserId.LineThickness = 3;
            this.UserId.Location = new System.Drawing.Point(26, 104);
            this.UserId.Margin = new System.Windows.Forms.Padding(4);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(292, 44);
            this.UserId.TabIndex = 5;
            this.UserId.Text = "User Id";
            this.UserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserId.OnValueChanged += new System.EventHandler(this.UserId_OnValueChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 388);
            this.Controls.Add(this.Register_Login);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Register_Login;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserId;
    }
}