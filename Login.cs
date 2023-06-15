using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MGcam
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mg" && textBox2.Text == "mg")
            {
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }
    }
}
