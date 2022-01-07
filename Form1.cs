using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            WrongLabel.Visible = false;
            WrongLebel2.Visible = false;
        }

        private void txtSelectedUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSelectedUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if(txtSelectedUser.SelectedIndex == 1)
            {
                panel2.Visible = false;
                panel1.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.PasswordChar = '\0';
                checkBox1.Text = "Hide password";
            }
            else
            {
                txtPass.PasswordChar = '$';
                checkBox1.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text =="admin" && txtPass.Text =="admin")
            {
                WrongLabel.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                WrongLabel.Visible = true;
            }
        }
    }
}
