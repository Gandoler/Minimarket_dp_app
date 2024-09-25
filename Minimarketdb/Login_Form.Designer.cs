namespace Minimarketdb
{
    partial class Login_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            this.Button_exit = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_clear = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-271, -56);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(505, 473);
            this.guna2CircleButton1.TabIndex = 0;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(240, 138);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(240, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 56);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вход";
            // 
            // TextBox_username
            // 
            this.TextBox_username.BorderRadius = 10;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = "";
            this.TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.Location = new System.Drawing.Point(365, 138);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.Size = new System.Drawing.Size(200, 36);
            this.TextBox_username.TabIndex = 4;
            this.TextBox_username.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderRadius = 10;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Location = new System.Drawing.Point(365, 189);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(200, 36);
            this.TextBox_password.TabIndex = 5;
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.Color.Transparent;
            this.Button_login.BorderRadius = 10;
            this.Button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_login.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.Black;
            this.Button_login.Location = new System.Drawing.Point(394, 249);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(145, 36);
            this.Button_login.TabIndex = 6;
            this.Button_login.Text = "Вход";
            // 
            // Button_exit
            // 
            this.Button_exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_exit.BorderColor = System.Drawing.Color.Transparent;
            this.Button_exit.BorderRadius = 10;
            this.Button_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_exit.FillColor = System.Drawing.Color.Transparent;
            this.Button_exit.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_exit.ForeColor = System.Drawing.Color.Black;
            this.Button_exit.Location = new System.Drawing.Point(562, 1);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(89, 65);
            this.Button_exit.TabIndex = 8;
            this.Button_exit.Text = "X";
            this.Button_exit.Click += new System.EventHandler(this.guna2Button2_Click);
            this.Button_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_exit_MouseClick);
            this.Button_exit.MouseEnter += new System.EventHandler(this.guna2Button2_MouseEnter);
            this.Button_exit.MouseLeave += new System.EventHandler(this.Button_exit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(183, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Мини маркет бд";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Button_clear
            // 
            this.Button_clear.BorderColor = System.Drawing.Color.Transparent;
            this.Button_clear.BorderRadius = 10;
            this.Button_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_clear.FillColor = System.Drawing.Color.Transparent;
            this.Button_clear.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_clear.ForeColor = System.Drawing.Color.Black;
            this.Button_clear.Location = new System.Drawing.Point(394, 315);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(145, 36);
            this.Button_clear.TabIndex = 10;
            this.Button_clear.Text = "Очистить";
            this.Button_clear.Click += new System.EventHandler(this.guna2Button1_Click);
            this.Button_clear.MouseEnter += new System.EventHandler(this.Button_clear_MouseEnter);
            this.Button_clear.MouseLeave += new System.EventHandler(this.Button_clear_MouseLeave);
            // 
            // comboBox_role
            // 
            this.comboBox_role.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Админ",
            "Продавец"});
            this.comboBox_role.Location = new System.Drawing.Point(365, 89);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(200, 38);
            this.comboBox_role.TabIndex = 11;
            this.comboBox_role.Text = "Выбрать роль";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private Guna.UI2.WinForms.Guna2Button Button_exit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Button_clear;
        private System.Windows.Forms.ComboBox comboBox_role;
    }
}

