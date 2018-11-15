using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFranceVacanceUWP.Model
{
    class UserCatalog
    {
        private static UserCatalog _instance = new UserCatalog();
        public static UserCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<User> Users { get; set; } //normal liste?

        private UserCatalog()
        {
            Users = new ObservableCollection<User>();

            //default users
            User defaultUser1 = new User("admin", "admin");
            User defaultUser2 = new User("user", "password");
            User defaultUser3 = new User("ebbevang", "ebbevang");
            User defaultUser4 = new User("heho", "heho");
            User defaultUser5 = new User("test123", "test123");
        }

        public void Add(string userName, string passWord)
        {
            Users.Add(new User(userName, passWord));
        }
    }
}
