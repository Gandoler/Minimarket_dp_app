namespace Minimarketdb
{
    partial class Splash_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(210, 47);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mini Market Db ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.ProgressBar.Location = new System.Drawing.Point(161, 130);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.ProgressBar.Size = new System.Drawing.Size(342, 21);
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Text = "guna2ProgressBar1";
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar.UseTransparentBackground = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-39, 197);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(729, 539);
            this.guna2CircleButton1.TabIndex = 4;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // Splash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Form";
            this.Load += new System.EventHandler(this.Splash_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}