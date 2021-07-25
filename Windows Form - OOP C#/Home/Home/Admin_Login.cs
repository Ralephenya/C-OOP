using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Home
{
    public partial class Admin_Login : Form
    {
		
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void A_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void A_HOME_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.ShowDialog();
        }

        private void hidepassword_Click(object sender, EventArgs e)
        {
            


                if (hidepassword.Tag.ToString().ToLower() == "hide")
                {
                    hidepassword.BackgroundImage = Properties.Resources.eye;
                    hidepassword.Tag = "";
                    A_Password.PasswordChar = char.Parse("\0");
                }
                else
                {
                    hidepassword.BackgroundImage = Properties.Resources.hide;
                    hidepassword.Tag = "hide";
                    A_Password.PasswordChar = '*';
                }
            
        }

        private void btnLogin(object sender, EventArgs e)
        {
            Admin_Portal admin_Portal = new Admin_Portal();

            try
            {
                Admin admin = new Admin(A_Username.Text, A_Password.Text);
                admin.SignIn();
                admin_Portal.ShowDialog();
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Your usernane/password is incorrect");
            }
        }
    }
}
