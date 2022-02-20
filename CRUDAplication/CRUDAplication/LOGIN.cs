using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAplication
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Userbox_Enter(object sender, EventArgs e)
        {
            if(Userbox.Text == "User Name")
            {
                Userbox.Text = "";

                Userbox.ForeColor = Color.Black;

            }
        }

        private void Userbox_Leave(object sender, EventArgs e)
        {
            if (Userbox.Text == " ")
            {
                Userbox.Text = "User Name";

                Userbox.ForeColor = Color.Black;

            }
        }

        private void Emailbox_Enter(object sender, EventArgs e)
        {
            if (Emailbox.Text == "add@yahoo.com")
            {
                Emailbox.Text = "";

                Emailbox.ForeColor = Color.Black;
            }
        }

        private void Emailbox_leave(object sender, EventArgs e)
        {
            if (Emailbox.Text == "")
            {
                Emailbox.Text = "add@yahoo.com";

                Emailbox.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

