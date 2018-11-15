using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFranceVacanceUWP.Model
{
    class User
    {
        private string _userName;
        private string _passWord;

        public string UserName { get => _userName; }
        public string PassWord { get => _passWord; set => _passWord = value; }

        public User(string userName, string passWord)
        {
            _userName = userName;
            _passWord = passWord;
        }
    }
}
