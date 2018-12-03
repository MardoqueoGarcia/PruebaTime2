using PruebaTime.ViewModel.MasterViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaTime.ViewModel.TabbedsViewModels
{
    public class PasatiemposViewModel : BaseViewModel
    {
        public PasatiemposViewModel()
        {
            NumberRandow();
        }

        //Numero ingresado
        private int number;
        public int Number
        {
            get { return number; }
            set { SetValue(ref this.number, value); }
        }

        //Numero resultado
        private string resultado;
        public string Resultado
        {
            get { return resultado; }
            set { SetValue(ref this.resultado, value); }
        }

        //Contador de intentos
        private int intent;
        public int Intent
        {
            get { return intent; }
            set { SetValue(ref this.intent, value); }
        }

        //Command
        public ICommand NumberCommand
        {
            get
            {
                return new Command(NumberRandow);
            }
        }

        //Metodo del Comando
        public void NumberRandow()
        {
            Random random = new Random();

            var numb = random.Next(1,30);
            //Si no esta vacio el campo del numero
            if (!string.IsNullOrEmpty(Convert.ToString(Number)))
            {
                //Si el numero es mayor a 30
                if (Number > 30 || Number < 0)
                {
                    App.Current.MainPage.DisplayAlert("Error","Ingresa un número menor que 50 y mayor que 1","Aceptar");
                }
                else
                {
                    //Si el numero es igual al numero randow
                    if (Number != numb)
                    {
                        Intent++;
                        Resultado = "Estuvistes cerca, el numero era: " + numb + ". Vuelve a intentarlo.";
                    }
                    else
                    {
                        App.Current.MainPage.DisplayAlert
                            ("Notificación", 
                            "Felicidades!! GANASTES." + "\n" + "Tu número ganador es: "
                            + numb + "\n" + "El número de intentos fue: " + intent + ".",
                            "Aceptar");

                        Resultado = "Felicidades!! GANASTES."  + "\n" + "Tu número ganador es: " + numb
                            + "\n" + "El número de intentos fue: " + intent + ".";
                        Intent = 0;
                    }
                }
            }
            else
            {
                App.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar un número.",
                    "Aceptar");
            }
            


            

        }
    }
}
