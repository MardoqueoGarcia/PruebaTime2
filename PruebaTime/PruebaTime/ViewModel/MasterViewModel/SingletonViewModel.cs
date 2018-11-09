using PruebaTime.Views.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTime.ViewModel.MasterViewModel
{
    public class SingletonViewModel
    {
        #region Instancias de los ViewModels

        //Instancia de nuestro Menú
        public MainPageViewModel Menu
        {
            get;
            set;
        }

        //Instancia de nuestra pagina de detalle
        public InicioPage Inicio
        {
            get;
            set;
        }

        //Instancia de nuestro Login
        public LoginPage Login
        {
            get;
            set;
        }

        //Instancia de nuestros chistes
        public ChistesViewModel Chistes
        {
            get;
            set;
        }
        #endregion

        //Instancia de nuestro buscador
        public SearchViewModel Search
        {
            get;
            set;
        }

        #region Constructor
        public SingletonViewModel()
        {
            //Utilizaremos nuestra instancia de neustro Singleton
            instance = this;


            this.Login = new LoginPage();
            this.Menu = new MainPageViewModel();
            this.Inicio = new InicioPage();
            this.Chistes = new ChistesViewModel();
            this.Search = new SearchViewModel();

        }
        #endregion

        #region Methods Singleton
        private static SingletonViewModel instance;

        public static SingletonViewModel GetInstance()
        {
            if (instance == null)
            {
                return new SingletonViewModel();
            }

            return instance;
        }
        #endregion
    }
}
