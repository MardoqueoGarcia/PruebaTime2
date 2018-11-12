﻿using PruebaTime.Models;
using PruebaTime.Repository;
using PruebaTime.Views.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTime.ViewModel.MasterViewModel
{
    public class SingletonViewModel
    {
        #region Instancias de los ViewModels

        //Lista de categoria de chistes
        public List<ChistesModel> ChistesListt
        {
            get;
            set;
        }

        //Lista de todos los chistes
        public List<ListChistesModel> GetList
        {
            get;
            set;
        }


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

        //Instancia de nuestro buscador
        public ChistesRepository Repository
        {
            get;
            set;
        }

        //Instancia de nuestro buscador
        public SearchViewModel Search
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
            this.Chistes = new ChistesViewModel();
            this.Search = new SearchViewModel();
            this.Repository = new ChistesRepository();

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
