using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewsModel
{
    using Models;
    public class CurrenciesViewModel
    {
        #region Properties
        public Currency Currencies
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public CurrenciesViewModel(List<Currency> currency)
        {
            this.Currencies = currency[0];
        }
        #endregion
    }
}
