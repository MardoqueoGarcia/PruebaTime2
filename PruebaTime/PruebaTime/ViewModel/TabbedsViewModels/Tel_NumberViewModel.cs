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
    public class Tel_NumberViewModel : BaseViewModel
    {
        #region Commands
        public ICommand LlamarCommand
        {
            get
            {
                return new Command(Llamar);
            }
        }

        public ICommand MensajeCommand
        {
            get
            {
                return new Command(Mensaje);
            }
        }

        public ICommand CancelarCommand
        {
            get
            {
                return new Command(Cancelar);
            }
        }
        #endregion

        #region Methods
        //Realizar llamda
        public async void Llamar()
        {
            var number = "(+503)76844206";
            var phonecalltask = CrossMessaging.Current.PhoneDialer;
            if (phonecalltask.CanMakePhoneCall)
            {
                phonecalltask.MakePhoneCall(number);
            }

            await PopupNavigation.PopAsync();

        }

        //enviar mensaje de texo
        public async void Mensaje()
        {

           var number = "(+503)76844206";
           var msj = CrossMessaging.Current.SmsMessenger;

           if (msj.CanSendSms)
           {
              msj.SendSms(number);
           }

            await PopupNavigation.PopAsync();
        }

        //Cancelar accion
        public async void Cancelar()
        {
            await PopupNavigation.PopAsync();
        }
        #endregion
    }
}
