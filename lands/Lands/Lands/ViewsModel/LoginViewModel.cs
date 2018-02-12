using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewsModel
{
    using Xamarin.Forms;
    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemembered { get; set; }

        #endregion
        #region Constructor
        public LoginViewModel()
        {
            
        }
        #endregion
        #region Commands
        //public ICommand LoginCommand => new RelayCommand(Login);
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "You must enter an email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "You must enter an password",
                    "Accept");
                return;
            }
        }
       
        #endregion
    }
}
