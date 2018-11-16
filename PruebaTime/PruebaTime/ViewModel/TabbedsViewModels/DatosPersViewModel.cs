using Android.Content;
using System;
using Plugin.Messaging;
using Xamarin.Forms;
using Android.App;
using System.Windows.Input;
using Rg.Plugins.Popup.Services;
using PruebaTime.Views.Tabbeds;
using PruebaTime.ViewModel.MasterViewModel;

namespace PruebaTime.ViewModel.TabbedsViewModels
{
    public class DatosPersViewModel
    {
        #region Command
        //Comando para ver la foto del contacto 
        public ICommand PhotoCommand
        {
            get
            {
                return new Command(Photo);
            }
        }

        //Comando para buscar la direccion en el mapa
        public ICommand DireccionCommand
        {
            get
            {
                return new Command(Direccion);
            }
        }

        //Comando para navegar a las llamadas 
        public ICommand LlamarCommand
        {
            get
            {
                return new Command(Llamar);
            }
        }

        //Comando para navegar al correo
        public ICommand EmailCommand
        {
            get
            {
                return new Command(Email);
            }
        }
        #endregion

        #region Methods
        //Metodo del foto
        public void Photo()
        {
            var mensaje = "No hay imagen disponible :( Por favor intentalo más tarde.";
            DependencyService.Get<IMessage>().LongTime(mensaje);
        }

        //Metodo de la direccion 
        public void Direccion()
        {
            var url = "https://www.google.com/maps/place/Colonia+Santa+Emilia+Park/@13.476924,-88.1649592,178m/data=!3m1!1e3!4m5!3m4!1s0x8f7ad588e3389fd3:0x6af4c4c14083f973!8m2!3d13.4765803!4d-88.1650673";
            
             Device.OpenUri(new Uri(url));
        }

        //Metodo de la llamada
        public async void Llamar()
        {
            //Para llamar al popup

            SingletonViewModel.GetInstance().Tel_Number = new Tel_NumberViewModel();

            await PopupNavigation.PushAsync(new Tel_NumerPopupPage());
            
        }


        //Metodo para navegar al correo
        public async void Email()
        {
            //Llamar nuestro formulario Popup

            SingletonViewModel.GetInstance().Email_Formulario = new EmailFormularioViewModel();

            await PopupNavigation.PushAsync(new EmailFormularioPage());
            
        }
        #endregion
    }
}
