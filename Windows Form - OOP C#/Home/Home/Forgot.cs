using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Home
{
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }
       

        private void btnChecker(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(F_Surname.Text) || string.IsNullOrWhiteSpace(F_Pet.Text) || string.IsNullOrWhiteSpace(F_Cell.Text))
                {
                    MessageBox.Show("Please check if you filled everything");


                }
                else
                {
                    Registration registration = new Registration(F_Pet.Text, F_Surname.Text, F_Cell.Text);


                    MessageBox.Show(registration.ToString());


                }



            }
            catch (Exception er)
            {

                MessageBox.Show("Something went wrong :" + er);
            }

        }

        private void BackToLogin(object sender, EventArgs e)
        {
            Student_Login student_Login = new Student_Login();
            this.Hide();
            student_Login.ShowDialog();
        }
    }
    
}
