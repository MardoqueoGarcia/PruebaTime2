using PruebaTime.Models;
using PruebaTime.ViewModel.MasterViewModel;
using PruebaTime.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel
{
    public class ChistesViewModel : BaseViewModel
    {
        #region Constructor

        public ChistesViewModel()
        {
            //Cargamos nuestros lista
            LoadListCategory();
        }
        #endregion

        #region Attributes
        private ObservableCollection<ChistesModel> chistes { get; set; }
        private ListChistesModel selectedCategory { get; set; }
        #endregion

        #region Properties
        //LLenar la vista de datos
        public ObservableCollection<ChistesModel> Chistes
        {
            get { return this.chistes; }
            set { this.chistes = value;
                OnPropertyChanged();
            }
        }

        //Guardar seleccion de datos
        public ListChistesModel SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                if (selectedCategory != value)
                {
                    selectedCategory = value;
                    LoadListCategory();
                }
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

        //Para cagar los chistes
        public void LoadListCategory()
        {
            List<ChistesModel> ChistesList = new List<ChistesModel>();
            ChistesList.Add(new ChistesModel { Category = "Animales"});
            ChistesList.Add(new ChistesModel { Category = "Borrachos" });
            ChistesList.Add(new ChistesModel { Category = "Futbol" });
            ChistesList.Add(new ChistesModel { Category = "Mamá, mamá" });
            ChistesList.Add(new ChistesModel { Category = "Navidad" });
            ChistesList.Add(new ChistesModel { Category = "Pepito" });
            ChistesList.Add(new ChistesModel { Category = "Policías" });
            ChistesList.Add(new ChistesModel { Category = "Suegras" });

            //guardamos la lista en nuestro singleton
           List<ChistesModel> lista = SingletonViewModel.GetInstance().ChistesListt = ChistesList;

            Chistes = new ObservableCollection<ChistesModel>(lista);
        }
        #endregion
    }
}
