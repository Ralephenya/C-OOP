using System;
using System.Collections.Generic;
using System.Text;

namespace Home
{
    abstract class Login:Registration
    {
        public Login()
        {

        }


        public Login(string username, string password):base(username,password)
        {
            this.username = username;
            this.password = password;
        }


        public abstract void SignIn();


    }
}
