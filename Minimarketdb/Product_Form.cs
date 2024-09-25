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
    public partial class Product_Form : Form
    {
        db_connect db_Connect = new db_connect();
        public Product_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_but_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_price.Text == "" || TextBox_name.Text == "" || TextBox_quantity.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertQuery = "INSERT INTO Product VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_price.Text + "','" + TextBox_quantity.Text + "','" + comboBox_category.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно добавлена", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db_Connect.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {

        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand(selectQuery, db_Connect.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void refresh_button_Click_1(object sender, EventArgs e)
        {
            getTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void category_button_Click(object sender, EventArgs e)
        {
            Category_Form category_Form = new Category_Form(); 
            category_Form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                comboBox_category_up.DataSource = table;
                comboBox_category_up.ValueMember = "CatName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_quantity.Clear();
            TextBox_price.Clear();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_price.Text == "" || TextBox_name.Text == "" || TextBox_quantity.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updatetQuery = "UPDATE Product SET ProductName='" + TextBox_name.Text + "',ProdPrice='" + TextBox_price.Text +"', ProdQty = '" + TextBox_quantity.Text+"' , ProdCat = '" + comboBox_category.Text + "'WHERE ProdId=" + TextBox_id.Text + " ";
                    SqlCommand command = new SqlCommand(updatetQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Продукт успешно обновлена", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db_Connect.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Продукт успешно Удалена", "DELETE Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db_Connect.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.FromArgb(118, 138, 151);
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_quantity.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void comboBox_category_up_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM Product WHERE ProdCat='"+ comboBox_category_up.Text+"'";
                SqlCommand command = new SqlCommand(selectQuery, db_Connect.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
