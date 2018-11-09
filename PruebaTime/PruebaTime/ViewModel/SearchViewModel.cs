using PruebaTime.ViewModel.MasterViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel
{
    public class SearchViewModel : BaseViewModel
    {
        #region Constructor
        public SearchViewModel()
        {
        }
        #endregion

        #region Attributes
        public bool isVisiblelb { get; set; }
        #endregion

        #region Properties

        public bool IsVisiblelb
        {
            get { return this.isVisiblelb; }
            set
            {
                isVisiblelb = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        public ICommand VolverCommand
        {
            get
            {
                return new Command(Volver);
            }
        }
        #endregion

        #region Methods

        //Para volver atras
        public void Volver()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
        #endregion
    }
}
