using PruebaTime.Models;
using PruebaTime.Repository;
using PruebaTime.ViewModel.MasterViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel
{
    public class SearchViewModel : BaseViewModel
    {
        //Constructor
        #region Constructor
        public SearchViewModel()
        {
            IsVisibleList = false;
        }
        #endregion

        #region Attributes
        private string filter;
        private bool isVisibleList;
        private ObservableCollection<ListChistesModel> chistes;
        #endregion

        #region Properties

        //Para guardar lo que digite en el search
        public string Filter
        {
            get { return this.filter; }
            set
            {
                SetValue(ref this.filter, value);
                this.SearchCategory();
            }
        }

        //Cargarlos a la vista
        public ObservableCollection<ListChistesModel> Chistes
        {
            get { return chistes; }
            set { SetValue(ref this.chistes, value); }
        }

        //Ocultar la lista
        public bool IsVisibleList
        {
            get { return this.isVisibleList; }
            set { SetValue(ref this.isVisibleList, value); }
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

        //Para el buscador
        public ICommand SearchCommand
        {
            get
            {
                return new Command(SearchCategory);
            }
        }
        #endregion

        #region Methods

        //Para volver atras
        public void Volver()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        //Buscar por Categoria
        public void SearchCategory()
        {
            var lista = SingletonViewModel.GetInstance().GetList;

            if (string.IsNullOrEmpty(this.Filter) || this.Filter.Length == 0)
            {
                IsVisibleList = true;
                this.Chistes = new ObservableCollection<ListChistesModel>(lista);
            }

            else
            {
                IsVisibleList = true;
                this.Chistes = new ObservableCollection<ListChistesModel>
                    (lista.Where
                    (
                        c => c.Category.ToLower().Contains(this.Filter.ToLower())
                    ));
            }
        }
        #endregion
    }
}
