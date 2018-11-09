using PruebaTime.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel
{
    public class ChistesViewModel
    {
        #region Constructor

        public ChistesViewModel()
        {
          
        }
        #endregion

        #region Properties

        #endregion

        #region Commands

        public ICommand SearchCommand
        {
            get
            {
                return new Command(SearchNavigator);
            }
        }
        #endregion

        #region Methods

        public void SearchNavigator()
        {
            App.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }
        #endregion
    }
}
