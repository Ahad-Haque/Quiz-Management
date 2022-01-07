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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = false;
            uC_UpdateQuestion1.Visible = false;
            uC_ViewDeleteQuestion1.Visible = false;
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = true;
            addNewQuestion1.BringToFront();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uC_UpdateQuestion1.Visible = true;
            uC_UpdateQuestion1.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            uC_ViewDeleteQuestion1.Visible = true;
            uC_ViewDeleteQuestion1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
