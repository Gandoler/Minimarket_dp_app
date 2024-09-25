using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarketdb
{
    public partial class Selling_Form : Form
    {
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
            Button_exit.ForeColor = Color.Red;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            Button_exit.ForeColor = Color.FromArgb(118, 138, 151);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

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

        }
    }
}
