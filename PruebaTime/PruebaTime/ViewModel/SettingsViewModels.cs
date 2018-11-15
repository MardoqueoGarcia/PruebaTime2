using Plugin.Media.Abstractions;
using PruebaTime.ViewModel.Servicios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PruebaTime.ViewModel
{
    public class SettingsViewModels : BindableObject
    {
        //Ruta de la foto
        public static readonly BindableProperty RutaFotoproperty =
            BindableProperty.Create
            ("RutaFoto",
             typeof(string),
             typeof(SettingsViewModels),
             default(string));

        //Ruta de la foto
        public string RutaFoto
        {
            get
            {
                return (string)GetValue(RutaFotoproperty);
            }
            set
            {
                SetValue(RutaFotoproperty, value);
            }
        }

        private MediaFile Foto;
        //Comando de seleccionar una foto
        public Command m_seleccionarFotoCommand;
        public Command SeleccionarFotoCommand
        {
            get
            {
                return (m_seleccionarFotoCommand ?? (m_seleccionarFotoCommand =
                    new Command(async () => await SeleccionarFotoAsync())));

            }
        }

        //Metodo del comando seleccionar foto
        public async Task<bool> SeleccionarFotoAsync()
        {
            int nErrores = 0;
            try
            {
                Foto = await ServicioFoto.Instancia.SeleccionarFotoAsync();
                if (Foto != null)
                {
                    RutaFoto = Foto.Path;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                nErrores++;
            }

            return (nErrores == 0);
        }

        public SettingsViewModels()
        {

        }
    }
}
