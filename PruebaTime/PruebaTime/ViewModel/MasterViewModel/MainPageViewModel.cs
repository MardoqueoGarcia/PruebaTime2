using System.Collections.ObjectModel;

namespace PruebaTime.ViewModel.MasterViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Construtor

        public MainPageViewModel()
        {
            //Cargamos nuestro menú
            LoadMenu();
        }
        #endregion

        #region Attributes

        public ObservableCollection<MenuPageViewModel> Menu
        {
            get;
            set;
        }
        #endregion

        #region Methods

        public void LoadMenu()
        {
            Menu = new ObservableCollection<MenuPageViewModel>();

            Menu.Add(new MenuPageViewModel
            {
                Icon = "ic_home.png",
                PageName = "InicioPage",
                Title = "Pagina Principal"
            });

            Menu.Add(new MenuPageViewModel
            {
                Icon = "ic_datos.png",
                PageName = "HomeTabbedPage",
                Title = "Datos Personales"
            });

            Menu.Add(new MenuPageViewModel
            {
                Icon = "ic_chistes.png",
                PageName = "ChistesPage",
                Title = "Chistes"
            });

            Menu.Add(new MenuPageViewModel
            {
                Icon = "ic_calculator.png",
                PageName = "CalculatorPage",
                Title = "Calculadora"
            });

            Menu.Add(new MenuPageViewModel
            {
                Icon = "ic_settings.png",
                PageName = "SettingsPage",
                Title = "Configuración"
            });

            Menu.Add(new MenuPageViewModel
            {
                Icon = "ic_logout.png",
                PageName = "LogoutPage",
                Title = "Cerrar Sesión"
            });
        }
        #endregion
    }
}
