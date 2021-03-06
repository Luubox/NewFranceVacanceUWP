﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using NewFranceVacanceUWP.Model;

namespace NewFranceVacanceUWP.ViewModel
{
    class BoligViewModel : INotifyPropertyChanged
    {
        public BoligCatalog BoligCatalog { get; set; }

        public BoligViewModel()
        {
            BoligCatalog = BoligCatalog.Instance;
        }

        //TODO: Commands, Binding, Test serialization, GUI, RelayCommand??
        #region Test binding / commands   
        ////TODO: Opdater så det virker med collection etc
        //public BoligCatalog BoligCatalog { get; set; }
        //private RelayCommand _buttonRelayCommand;

        //string _textBlockText;

        //public BoligViewModel()
        //{
        //    TextBlockText = "It Works!";
        //    ButtonRelayCommand = new RelayCommand(DoSomething);
        //}

        //public string TextBlockText
        //{
        //    get => _textBlockText;
        //    set
        //    {
        //        _textBlockText = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public RelayCommand ButtonRelayCommand
        //{
        //    get { return _buttonRelayCommand; }
        //    set { _buttonRelayCommand = value; }
        //}

        //public void DoSomething()
        //{
        //    TextBlockText = "tadaa";
        //}
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        //der er fjernet en linje per NKragh's request, hvis det går i udu hiv fat i ham.
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
