using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using NewFranceVacanceUWP.Annotations;
using NewFranceVacanceUWP.Model;

namespace NewFranceVacanceUWP.ViewModel
{
    class UserViewModel : INotifyPropertyChanged
    {
        private User _tempUser;

        private string _message = "";
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public UserCatalog UserCatalog { get; set; }
        public RelayCommand LoginCommand { get; set; }

        public UserViewModel()
        {
            UserCatalog = UserCatalog.Instance;
            LoginCommand = new RelayCommand(UserLogin);
        }

        private void UserLogin()
        {
            Debug.WriteLine("its alive!");
            Message = "TestMessage!";


        }


        public void CheckCredentials()
        {
            foreach (User u in UserCatalog.Users)
            {
                if (u.Equals(_tempUser))
                {
                    Message = "Login Successful";
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
