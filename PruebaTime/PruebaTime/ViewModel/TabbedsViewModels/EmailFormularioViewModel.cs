using Plugin.Messaging;
using PruebaTime.ViewModel.MasterViewModel;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel.TabbedsViewModels
{
    public class EmailFormularioViewModel : BaseViewModel
    {
        #region Attributes
        private string asunto;
        private string mensaje;
        private string correo;
        #endregion

        #region Properties
        public string Asunto
        {
            get { return asunto; }
            set { SetValue(ref asunto, value); }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { SetValue(ref mensaje, value); }
        }

        public string Correo
        {
            get { return correo; }
            set { SetValue(ref correo, value); }
        }
        #endregion


        #region Commands

        public ICommand CancelarCommand
        {
            get
            {
                return new Command(Cancelar);
            }
        }

        public ICommand EnviarCommand
        {
            get
            {
                return new Command(Enviar);
            }
        }
        #endregion

        #region Methods
        public async void Cancelar()
        {
            await PopupNavigation.PopAsync();
        }

        public async void Enviar()
        {
            Correo = "mardoqueogarcia112016@gmail.com";

            var EmailMsj = CrossMessaging.Current.EmailMessenger;

            if (EmailMsj.CanSendEmail)
            {
                EmailMsj.SendEmail
                 (
                   Correo,
                   Asunto, 
                   Mensaje);
            }

            await PopupNavigation.PopAsync();
        }
        #endregion
    }
}
