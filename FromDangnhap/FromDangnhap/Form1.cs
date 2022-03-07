using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromDangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtpassword.Text == "admin")
            {
                Form2 newForm = new Form2();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
                txtUserName.Clear();
                txtpassword.Clear();
            }

        }
    }
}
