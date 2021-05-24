using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    public class User
    {
        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}
