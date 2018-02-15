namespace Lands.ViewsModel
{
    public class MainViewModel
    {
        #region Views
        public LoginViewModel Login {
            get;
            set;
        }

        public LandsViewModel Lands {
            get;
            set;
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            //this.Lands = new LandsViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
