﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class User
    {
        public string Login; //{ get; }
        public string Password; //{ get; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
