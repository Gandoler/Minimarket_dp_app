using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Minimarketdb
{
    public partial class Selling_Form : Form
    {
        db_connect db_Connect = new db_connect();
        public Selling_Form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            Seller_Form seller_Form = new Seller_Form();
            seller_Form.Show();
            this.Hide();
        }

        private void Product_button_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form();
            product_Form.Show();
            this.Hide();
        }

        private void category_button_Click(object sender, EventArgs e)
        {
            Category_Form category_Form = new Category_Form();
            category_Form.Show();
            this.Hide();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_exit_MouseEnter(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Red;
        }

        private void Button_exit_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Black;
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.FromArgb(118, 138, 151);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        int GTotal = 0, n = 0;
        private void clear()
        {
            TextBox_id_sel.Clear();
            TextBox_name_sel.Clear();
            TextBox_qtry_sel.Clear();
            TextBox_price_sel.Clear();
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_id_sel.Text) || string.IsNullOrEmpty(TextBox_price_sel.Text) || string.IsNullOrEmpty(TextBox_qtry_sel.Text))
            {
                clear();
                MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                if (!int.TryParse(TextBox_id_sel.Text, out int id) || !int.TryParse(TextBox_price_sel.Text, out int price) || !int.TryParse(TextBox_qtry_sel.Text, out int quantity))
                {
                    MessageBox.Show("В поля 'ID', 'Цена' и 'Количество' должны быть введены только цифры.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int total = price * quantity;
                    DataGridViewRow add_row = new DataGridViewRow();
                    add_row.CreateCells(dataGridView_order);
                    add_row.Cells[0].Value = ++n;
                    add_row.Cells[1].Value = TextBox_name_sel.Text;
                    add_row.Cells[2].Value = TextBox_price_sel.Text;
                    add_row.Cells[3].Value = TextBox_qtry_sel.Text;
                    add_row.Cells[4].Value = total;
                    add_row.Cells[5].Value = WhoSeller();
                    dataGridView_order.Rows.Add(add_row);

                    GTotal += total;
                    total_label.Text = GTotal.ToString() + "$";
                }
            }
        }

        private string WhoSeller()
        {
            string returned_string = "";

            string updatetQuery = "SELECT SellerName FROM Seller WHERE Sellerid='" + TextBox_id_sel.Text + "'";
            SqlCommand command = new SqlCommand(updatetQuery, db_Connect.GetConnection());

            db_Connect.OpenCon();

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    returned_string = reader["SellerName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            db_Connect.CloseCon();

            return returned_string;
        }


        private void Update_button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT  ProductName, ProdPrice FROM Product WHERE ProdCat='" + comboBox_category.Text + "'";
                SqlCommand command = new SqlCommand(selectQuery, db_Connect.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getCategory()
        {
            try
            {
                string selectQuery = "SELECT * FROM Category";
                SqlCommand command = new SqlCommand(selectQuery, db_Connect.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBox_category.DataSource = table;
                comboBox_category.ValueMember = "CatName";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Selling_Form_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
            getTable_of_sales();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT ProductName, ProdPrice FROM Product";
                SqlCommand command = new SqlCommand(selectQuery, db_Connect.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void getTable_of_sales()
        {
            try
            {
                string selectQuery = "SELECT * FROM Sale";
                SqlCommand command = new SqlCommand(selectQuery, db_Connect.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                GridView_sales.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            TextBox_name_sel.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price_sel.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void total_label_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_order.Rows)
            {
                try
                {

                    string insertQuery = "INSERT INTO Product Sale(" + row.Cells[5].Value + ",'" + DateTime.Now.ToString("yyyy-MM-dd ") +"','" + row.Cells[4].Value + "')";
                    SqlCommand command = new SqlCommand(insertQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно добавлена", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db_Connect.CloseCon();
                    getTable();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                getTable_of_sales();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getTable();
        }
    }
}
