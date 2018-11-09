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
        #endregion

        #region Constructor
        public SingletonViewModel()
        {
            //Utilizaremos nuestra instancia de neustro Singleton
            instance = this;


            this.Login = new LoginPage();
            this.Menu = new MainPageViewModel();
            this.Inicio = new InicioPage();

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
