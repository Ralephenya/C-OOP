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
    public partial class Admin_Portal : Form
    {
        int pos;
        Admin admin = new Admin();

        public Admin_Portal()
        {
            InitializeComponent();
        }


        // Displaying information regarding pending 
        private void Admin_Portal_Load(object sender, EventArgs e)
        {
            try
            {

                admin.DataTable =  admin.FormLoader();
                pos = 0;
                CheckForStudebntRequest();
                
            }
            catch (Exception er)
            {

                MessageBox.Show("Something went wrong :"+er);
            }

        }


        public void CheckForStudebntRequest()
        {

            if (admin.DataTable.Rows.Count > 0)
            {
                displaytext(pos);

            }
            else
            {
                MessageBox.Show("There is no request from students");

            }

        }


        public void displaytext(int row_position)
        {

            R_Name.Text = admin.DataTable.Rows[row_position][0].ToString().Trim() + " " + admin.DataTable.Rows[row_position][1].ToString().Trim();
            R_Learning.Text = admin.DataTable.Rows[row_position][2].ToString();
            R_RequestNo.Text = "Number of requests :" + admin.DataTable.Rows[row_position][3].ToString();
            R_Reason.Text = admin.DataTable.Rows[row_position][4].ToString();


        }


        private void FormClosing1(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public void clear()
        {
            R_Name.Text = "";
            R_Learning.Text = "";
            R_Reason.Text = "";
            R_RequestNo.Text = "";
        }

        private void btnSearch(object sender, EventArgs e)
        {
            try
            {

                dataGridView.DataSource = admin.Search(A_Id.Text, A_Name.Text, A_Learning.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("There is nothing like that!!");
            }
        }

        private void ArrowLeftNav(object sender, EventArgs e)
        {
            pos = pos - 1;

            if (pos == -1)
            {
                pos = 0;
                MessageBox.Show("This is the first Record");
            }
            CheckForStudebntRequest();
        }

        private void ArrowRightNav(object sender, EventArgs e)
        {
            pos = pos + 1;
            if (pos >= admin.DataTable.Rows.Count)
            {
                pos--;
                MessageBox.Show("Last Record");

            }
            CheckForStudebntRequest();
        }

        private void btnApprove(object sender, EventArgs e)
        {
            try
            {
                admin.Approve(R_Reason.Text, R_Learning.Text, admin.DataTable.Rows[pos][0].ToString(), admin.DataTable.Rows[pos][1].ToString());
                pos = 0;
                clear();
                Admin_Portal_Load(sender, e);
            }
            catch (Exception er)
            {

                MessageBox.Show("Something went wrong :" + er);
            }
        }

        private void btnDisapprove(object sender, EventArgs e)
        {
            try
            {

                admin.DisApprove(R_Reason.Text, R_Learning.Text, admin.DataTable.Rows[pos][0].ToString(), admin.DataTable.Rows[pos][1].ToString());

                pos = 0;
                clear();
                Admin_Portal_Load(sender, e);

            }
            catch (Exception er)
            {

                MessageBox.Show("Something went wrong :" + er);
            }
        }
    }
}
