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
    public partial class Category_Form : Form
    {

        db_connect db_Connect = new db_connect();
        public Category_Form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Category";
                SqlCommand command = new SqlCommand(selectQuery,db_Connect.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try 
            {
                if (TextBox_id.Text == "" || TextBox_description.Text == "" || TextBox_name.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertQuery = "INSERT INTO Category VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_description.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Категория успешно добавлена", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Category_Form_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_description.Text == "" || TextBox_name.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updatetQuery = "UPDATE Category SET CatName='" + TextBox_name.Text + "',CatDes='" + TextBox_description.Text + "'WHERE CATId=" + TextBox_id.Text + " ";
                    SqlCommand command = new SqlCommand(updatetQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Категория успешно обновлена", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_description.Text = dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_description.Clear();
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
                    string deleteQuery = "DELETE FROM Category WHERE CatId="+ TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Категория успешно Удалена", "DELETE Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        

       

        private void Button_exit_MouseEnter_1(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Red;

        }

        private void Button_exit_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Black;
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.FromArgb(118, 138, 151);
        }

        private void button_leave_MouseEnter(object sender, EventArgs e)
        {
            button_leave.ForeColor = Color.Red;
        }

        private void button_leave_MouseLeave(object sender, EventArgs e)
        {
            button_leave.ForeColor = Color.FromArgb(118, 138, 151);
        }

        private void button_leave_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void Product_button_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form(); 
            product_Form.Show();
            this.Hide();
        }

        private void dataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seller_button_Click(object sender, EventArgs e)
        {
            Seller_Form seller_Form = new Seller_Form();
            seller_Form.Show();
            this.Hide();
        }

        private void selling_button_Click(object sender, EventArgs e)
        {
            Selling_Form selling_Form = new Selling_Form();
            selling_Form.Show();
            this.Hide();
        }
    }
}
