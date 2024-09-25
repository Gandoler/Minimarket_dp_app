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



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try 
            {
                string insertQuery = "INSERT INTO Category VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,db_Connect.GetConnection());
                db_Connect.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Категория успешно добавлена");
                db_Connect.CloseCon();
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
       
    }
}
