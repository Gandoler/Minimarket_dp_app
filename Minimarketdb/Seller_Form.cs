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

namespace Minimarketdb
{
    public partial class Seller_Form : Form
    {
        db_connect db_Connect = new db_connect();
        public Seller_Form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void category_button_Click(object sender, EventArgs e)
        {
            Category_Form category_Form = new Category_Form();
            category_Form.Show();
            this.Hide();
        }

        private void Product_button_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form();
            product_Form.Show();
            this.Hide();
        }
        private void clear()
        {
            TextBox_id_sel.Clear();
            TextBox_name_sel.Clear();
            TextBox_age_sel.Clear();
            TextBox_psw_sel.Clear();
            TextBox_ph_number_sel.Clear();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id_sel.Text == "" || TextBox_name_sel.Text == "" || TextBox_age_sel.Text == "" || TextBox_ph_number_sel.Text == "" || TextBox_psw_sel.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id_sel.Text + ",'" + TextBox_name_sel.Text + "','" + TextBox_age_sel.Text + "','" + TextBox_ph_number_sel.Text + "','" + TextBox_psw_sel.Text + "')";

                    SqlCommand command = new SqlCommand(insertQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon(); 
                    command.ExecuteNonQuery();
                    MessageBox.Show("Продавец успешно добавлена", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Seller_Form_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Seller";
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

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_product_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button_exit_Enter(object sender, EventArgs e)
        {
           
        }

        private void Button_exit_MouseEnter(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Red;
        }

        private void Button_exit_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.Black;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.FromArgb(118, 138, 151);

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id_sel.Text == "" || TextBox_name_sel.Text == "" || TextBox_age_sel.Text == "" || TextBox_ph_number_sel.Text == "" || TextBox_psw_sel.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updatetQuery = "UPDATE Seller SET SellerName='" + TextBox_name_sel.Text + "',SellerAge='" + TextBox_age_sel.Text + "',SellerPhone='" + TextBox_ph_number_sel.Text + "',SellerPsw='" + TextBox_psw_sel.Text +  "'WHERE SellerId=" + TextBox_id_sel.Text + " ";
                    SqlCommand command = new SqlCommand(updatetQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Продавец успешно обновлена", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (TextBox_id_sel.Text == "")
                {
                    clear();
                    MessageBox.Show("Неправильный ввод информации", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + TextBox_id_sel.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, db_Connect.GetConnection());
                    db_Connect.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Продавец успешно Удалена", "DELETE Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
