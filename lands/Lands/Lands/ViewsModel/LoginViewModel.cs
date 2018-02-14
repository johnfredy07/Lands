using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewsModel
{
    using GalaSoft.MvvmLight.Command;
    using Lands.Views;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class LoginViewModel : BaseViewModel
    {
      
        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isRemembered;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Email {
            get { return email; }
            set { SetValue(ref email, value); }
        }

        public string Password {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public bool IsRunning {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }

        public bool IsRemembered {
            get { return isRemembered; }
            set { SetValue(ref isRemembered, value); }
        }

        public bool IsEnabled { get; set; }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
            this.Email = "jf@hotmail.com";
            this.Password = "1234";
        }
        #endregion
        #region Commands
        public ICommand LoginCommand => new RelayCommand(Login);

        

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an password",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if(!this.Email.Equals("jf@hotmail.com") || !this.Password.Equals("1234"))
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "email or password incorrect",
                   "Accept");
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;
            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());
        }
       
        #endregion
    }
}
