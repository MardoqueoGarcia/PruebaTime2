﻿using PruebaTime.ViewModel.ChistesVM;
using PruebaTime.ViewModel.TabbedsViewModels;
using PruebaTime.Views;
using PruebaTime.Views.Master;
using PruebaTime.Views.Tabbeds;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel.MasterViewModel
{
    public class MenuPageViewModel
    {
        #region Properties

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion


        #region Commands

        public ICommand NavigateCommand
        {
            get
            {
                return new Command(Navigate);
            }
        }
        #endregion

        #region Methods
        private void Navigate()
        {
            //Ocultar Master
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "InicioPage":
                    App.Master.Detail = new NavigationPage(new InicioPage());
                    break;

                case "HomeTabbedPage":
                    //Instanciamos los datos
                    SingletonViewModel.GetInstance().DatosPersonales = new DatosPersViewModel();
                    App.Master.Detail = new NavigationPage(new HomeTabbedPage());
                    break;

                case "ChistesPage":
                    //Instanciamos el ViewModel
                    SingletonViewModel.GetInstance().Chistes = new ChistesViewModel();
                    App.Master.Detail = new NavigationPage(new ChistesPage());
                    break;

                case "CalculatorPage":
                    //Instancia de la calculadora
                    SingletonViewModel.GetInstance().Calculator = new CalculadoraVM.CalculadoraViewModel();
                    App.Master.Detail = new NavigationPage(new CalculatorPage());
                    break;

                case "SettingsPage":
                    App.Master.Detail = new NavigationPage(new SettingsPage());
                    break;

                case "LogoutPage":
                    App.Current.MainPage.DisplayActionSheet
                        (
                          "Alerta",
                          "No","Si",
                          "Cerrara su sesión"
                        );
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
