using PruebaTime.Models;
using PruebaTime.Repository;
using PruebaTime.Repository.ChistesViewModel;
using PruebaTime.ViewModel.MasterViewModel;
using PruebaTime.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel.ChistesViewModel
{
    public class ChistesViewModel : BaseViewModel
    {

        #region Constructor
        public ChistesViewModel()
        {
            //Cargamos nuestros lista
            ListaChistes();
        }
        #endregion

        #region Attributes
        private List<ListChistesModel> listChistes { get; set; }
        private int chistesAccount { get; set; }
        #endregion

        #region Properties
        public List<ListChistesModel> ListChistes
        {
            get { return listChistes; }
            set { listChistes = value;
                OnPropertyChanged();
            }
        }

        //Almacenaremos la lista de datos
        public List<ObservableGroupCollection<string, ListChistesModel>> GroupedData
        {
            get;
            set;
        }

        public int ChistesAccount
        {
            get { return chistesAccount; }
            set { chistesAccount = value;
                OnPropertyChanged();
            }
        }
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

        //Para la navegacion
        public void SearchNavigator()
        {
            App.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }

        //Mostrar todos los chistes
        public void ListaChistes()
        {
            ChistesRepository rep = new ChistesRepository();

            //Ordenamos los chistes por categoria
            ListChistes = rep.Listt.OrderBy(c => c.Category).ToList();

            //Almacenamos el numero de datos que tenemos
            ChistesAccount = rep.Listt.Count;

            //Ordenamos los datos
            GroupedData = ListChistes.OrderBy(c => c.Category)
                .GroupBy(c => c.Category.ToString())
                .Select(c => new ObservableGroupCollection<string, ListChistesModel>(c)).ToList();
        }
        #endregion
    }
}
