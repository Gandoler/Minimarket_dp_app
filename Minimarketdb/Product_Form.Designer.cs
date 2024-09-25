namespace Minimarketdb
{
    partial class Product_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_exit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.category_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.selling_button = new System.Windows.Forms.Button();
            this.seller_button = new System.Windows.Forms.Button();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(167)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.TextBox_category);
            this.panel1.Controls.Add(this.TextBox_quantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(161, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 593);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Button_exit.Font = new System.Drawing.Font("Showcard Gothic", 20.2F);
            this.Button_exit.ForeColor = System.Drawing.Color.Black;
            this.Button_exit.Location = new System.Drawing.Point(1055, 3);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(45, 36);
            this.Button_exit.TabIndex = 9;
            this.Button_exit.Text = "X";
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(35, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 10;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(156, 156);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(200, 31);
            this.TextBox_name.TabIndex = 7;
            this.TextBox_name.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(26, 157);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_price
            // 
            this.TextBox_price.BorderRadius = 10;
            this.TextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_price.DefaultText = "";
            this.TextBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.Location = new System.Drawing.Point(156, 221);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.Size = new System.Drawing.Size(200, 31);
            this.TextBox_price.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(49, 222);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена";
            // 
            // TextBox_quantity
            // 
            this.TextBox_quantity.BorderRadius = 10;
            this.TextBox_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_quantity.DefaultText = "";
            this.TextBox_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_quantity.Location = new System.Drawing.Point(156, 291);
            this.TextBox_quantity.Name = "TextBox_quantity";
            this.TextBox_quantity.PasswordChar = '\0';
            this.TextBox_quantity.PlaceholderText = "";
            this.TextBox_quantity.SelectedText = "";
            this.TextBox_quantity.Size = new System.Drawing.Size(200, 31);
            this.TextBox_quantity.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(14, 292);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(135, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Количество";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_category
            // 
            this.TextBox_category.AutoSize = true;
            this.TextBox_category.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.TextBox_category.Location = new System.Drawing.Point(22, 360);
            this.TextBox_category.Name = "TextBox_category";
            this.TextBox_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_category.Size = new System.Drawing.Size(119, 30);
            this.TextBox_category.TabIndex = 12;
            this.TextBox_category.Text = "Категория";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 31);
            this.comboBox1.TabIndex = 13;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.add_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.add_button.Location = new System.Drawing.Point(27, 433);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(81, 63);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_but_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_button.FlatAppearance.BorderSize = 0;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Delete_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.Delete_button.Location = new System.Drawing.Point(252, 433);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(104, 63);
            this.Delete_button.TabIndex = 15;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.Update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_button.FlatAppearance.BorderSize = 0;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Update_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.Update_button.Location = new System.Drawing.Point(133, 433);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(97, 63);
            this.Update_button.TabIndex = 16;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(482, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 31);
            this.comboBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(389, 10);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(89, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Товары";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // category_button
            // 
            this.category_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.category_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_button.FlatAppearance.BorderSize = 0;
            this.category_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.category_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.category_button.Location = new System.Drawing.Point(12, 265);
            this.category_button.Name = "category_button";
            this.category_button.Size = new System.Drawing.Size(141, 40);
            this.category_button.TabIndex = 20;
            this.category_button.Text = "Категория";
            this.category_button.UseVisualStyleBackColor = false;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.refresh_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.refresh_button.Location = new System.Drawing.Point(688, 43);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(148, 31);
            this.refresh_button.TabIndex = 21;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click_1);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.exit_button.Location = new System.Drawing.Point(12, 575);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(141, 63);
            this.exit_button.TabIndex = 22;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = false;
            // 
            // selling_button
            // 
            this.selling_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.selling_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selling_button.FlatAppearance.BorderSize = 0;
            this.selling_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selling_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.selling_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.selling_button.Location = new System.Drawing.Point(12, 205);
            this.selling_button.Name = "selling_button";
            this.selling_button.Size = new System.Drawing.Size(141, 40);
            this.selling_button.TabIndex = 23;
            this.selling_button.Text = "Продажи";
            this.selling_button.UseVisualStyleBackColor = false;
            // 
            // seller_button
            // 
            this.seller_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(90)))));
            this.seller_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seller_button.FlatAppearance.BorderSize = 0;
            this.seller_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seller_button.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.seller_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(138)))), ((int)(((byte)(151)))));
            this.seller_button.Location = new System.Drawing.Point(12, 148);
            this.seller_button.Name = "seller_button";
            this.seller_button.Size = new System.Drawing.Size(141, 40);
            this.seller_button.TabIndex = 22;
            this.seller_button.Text = "Продавец";
            this.seller_button.UseVisualStyleBackColor = false;
            this.seller_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(384, 92);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.Size = new System.Drawing.Size(528, 486);
            this.dataGridView_product.TabIndex = 22;
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 10;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(156, 91);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(200, 31);
            this.TextBox_id.TabIndex = 23;
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.seller_button);
            this.Controls.Add(this.selling_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.category_button);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Button_exit;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TextBox_category;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_quantity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button category_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button selling_button;
        private System.Windows.Forms.Button seller_button;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
    }
}