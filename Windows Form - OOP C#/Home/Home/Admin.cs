using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Home
{
    class Admin : Login
    {

        string path = "Server=tcp:studentsdata01.database.windows.net,1433;Initial Catalog=Students;Persist Security Info=False;User ID=Steve;Password=Ralephenya13jr;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        SqlConnection con;  //Declare SqlConnection object
        SqlCommand command;     //Declare SqlCommand object
        SqlDataAdapter adapter;
        DataTable dataTable;
        DataTable dt;

        public Admin()
        {

        }

        public Admin(string username, string password) : base(username, password)
        {
            this.username = username;
            this.password = password;
        }

        public DataTable DataTable { get => dataTable; set => dataTable = value; }
        public DataTable Dt { get => dt; set => dt = value; }



        public DataTable Search(string id, string name, string learningMethod)
        {
            con = new SqlConnection(path);
            Dt = new DataTable();
            con.Open();

            try
            {
                


                if (!(string.IsNullOrWhiteSpace(name)) && !(string.IsNullOrWhiteSpace(learningMethod)) && !(string.IsNullOrWhiteSpace(id)))
                {
                    
                    adapter = new SqlDataAdapter("select Student_Id , Student_Name, Student_Surname , Student_Cell, Learning_Method , Status from Student WHERE Student_Id = " + id + ", Student_Name = '" + name + "' , Learning_Method = ' " + learningMethod + "'  ORDER BY Student_Id ;", con);
                    adapter.Fill(Dt);

                    return Dt;
                   



                }

                else if (!(string.IsNullOrWhiteSpace(name)))
                {
                    
                    adapter = new SqlDataAdapter("select Student_Id , Student_Name, Student_Surname , Student_Cell, Learning_Method , Status from Student WHERE  Student_Name =  '" + name + "' ORDER BY Student_Id ; ", con);
                    adapter.Fill(Dt);

                    return Dt;
                    

                }

                else if (!(string.IsNullOrWhiteSpace(learningMethod)))
                {
                    
                    adapter = new SqlDataAdapter("select Student_Id , Student_Name, Student_Surname , Student_Cell, Learning_Method , Status from Student WHERE  Learning_Method =  '" + learningMethod + "' ORDER BY Student_Id ; ", con);
                    adapter.Fill(Dt);

                    return Dt;
                    

                }

                else if (!(string.IsNullOrWhiteSpace(id)))
                {
                   
                    adapter = new SqlDataAdapter("select Student_Id , Student_Name, Student_Surname , Student_Cell, Learning_Method , Status from Student WHERE  Student_Id =  '" + id + "' ORDER BY Student_Id; ", con);
                    adapter.Fill(Dt);

                    return Dt;
                  

                }
                else
                {
                    throw new Exception();
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

        public DataTable FormLoader()
        {

            try
            {
                con = new SqlConnection(path);
                dataTable = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter("select Student_Name, Student_Surname , Learning_Method, Request_Number , Reason from Student WHERE Status = 3 ORDER BY Student_Id ;", con);
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Approve(string reason, string learning, string name, string surname)
        {
            try
            {
                con = new SqlConnection(path);
                string query = @"UPDATE Student SET Status = 1  WHERE Reason = '" + reason + "' AND Learning_Method = '" + learning + "' AND Student_Name = '" + name + "' AND Student_Surname = '" + surname + "';";
                con.Open();
                command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

        }

        public void DisApprove(string reason, string learning, string name, string surname)
        {
            try
            {
                con = new SqlConnection(path);
                

                if (learning.ToLower().Contains("online"))
                {
                    string query = @"UPDATE Student SET Status = 1  WHERE Reason = '" + reason + "' AND Learning_Method = '" + learning + "' AND Student_Name = '" + name + "' AND Student_Surname = '" + surname + "';";
                    con.Open();
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                   

                }

                else if (learning.ToLower().Contains("face"))
                {
                    string query = @"UPDATE Student SET Status = 1  WHERE Reason = '" + reason + "' AND Learning_Method = '" + learning + "' AND Student_Name = '" + name + "' AND Student_Surname = '" + surname + "';";
                    con.Open();
                    command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();


                }

                else
                {
                    throw new Exception();
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }



        }




        public override void SignIn()
        {
            try
            {

                if (this.username.ToLower() == "admin" && this.password.ToLower() == "admin")
                {

                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
