using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GalaSoft.MvvmLight.Command;
using NewFranceVacanceUWP.Annotations;
using NewFranceVacanceUWP.Model;
using NewFranceVacanceUWP.View;

namespace NewFranceVacanceUWP.ViewModel
{
    class UserViewModel : INotifyPropertyChanged
    {
        public UserCatalog UserCatalog { get; set; }
        public RelayCommand LoginCommand { get; set; }

        private User _tempUser;
        public User TempUser
        {
            get { return _tempUser; }
            set
            {
                _tempUser = value;
                OnPropertyChanged();
            }
        }

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

        public UserViewModel()
        {
            UserCatalog = UserCatalog.Instance;
            LoginCommand = new RelayCommand(UserLogin);
            TempUser = new User();
        }

        private void UserLogin()
        {
            //Debug.WriteLine("its alive!");
            //Message = "TestMessage!";

            CheckCredentials();

            //TODO: create session?
        }

        public void CheckCredentials()
        {
            if (UserCatalog.Users.Contains(TempUser))
            {
                Message = "it works";
            }

            else
            {
                foreach (User u in UserCatalog.Users)
                {
                    //if (UserCatalog.Users.Contains(u)/*u.Equals(TempUser)*/) Message = "Login Successful";
                    //TODO: Check objekt på objekt i collection
                    if (u.UserName == TempUser.UserName)
                    {
                        if (u.PassWord != TempUser.PassWord)
                        {
                            Message = "Incorrect Password";
                            break;
                        }
                        else
                        {
                            Message = "Login Successful";
                            ((Frame)Window.Current.Content).Navigate(
                                typeof(BoligPage));
                            //TODO: Redirect delay ?
                            break;
                        }
                    }
                    else Message = "Invalid Username";
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
