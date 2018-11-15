using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFranceVacanceUWP.Model;

namespace NewFranceVacanceUWP.ViewModel
{
    class UserViewModel
    {
        public UserCatalog UserCatalog { get; set; }

        public UserViewModel()
        {
            UserCatalog = UserCatalog.Instance;
        }
    }
}
