using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

       

        private void student_Home(object sender, EventArgs e)
        {
            Student_Login student_Login = new Student_Login();
            this.Hide();
            student_Login.ShowDialog();
        }

        private void admin_home(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            this.Hide();
            admin_Login.ShowDialog();
        }
    }
}
