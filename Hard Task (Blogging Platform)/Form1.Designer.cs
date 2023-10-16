namespace ADV
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Blogs_Form1 = new System.Windows.Forms.Label();
            this.ProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Loading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Blogs_Form1
            // 
            this.Blogs_Form1.AutoSize = true;
            this.Blogs_Form1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogs_Form1.ForeColor = System.Drawing.Color.White;
            this.Blogs_Form1.Location = new System.Drawing.Point(151, 9);
            this.Blogs_Form1.Name = "Blogs_Form1";
            this.Blogs_Form1.Size = new System.Drawing.Size(105, 37);
            this.Blogs_Form1.TabIndex = 2;
            this.Blogs_Form1.Text = "Blogs";
            // 
            // ProgressBar
            // 
            this.ProgressBar.animated = false;
            this.ProgressBar.animationIterval = 5;
            this.ProgressBar.animationSpeed = 300;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressBar.BackgroundImage")));
            this.ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.LabelVisible = true;
            this.ProgressBar.LineProgressThickness = 8;
            this.ProgressBar.LineThickness = 5;
            this.ProgressBar.Location = new System.Drawing.Point(133, 55);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgressBar.MaxValue = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.ProgressColor = System.Drawing.Color.White;
            this.ProgressBar.Size = new System.Drawing.Size(150, 150);
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Value = 0;
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.ForeColor = System.Drawing.Color.White;
            this.Loading.Location = new System.Drawing.Point(176, 214);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(71, 15);
            this.Loading.TabIndex = 4;
            this.Loading.Text = "Loading...";
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(434, 242);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Blogs_Form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Blogs_Form1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgressBar;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Timer timer1;
    }
}

