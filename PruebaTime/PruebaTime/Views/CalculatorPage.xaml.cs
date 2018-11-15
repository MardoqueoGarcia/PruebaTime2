using Plugin.Geolocator;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using PruebaTime.ViewModel.CalculadoraVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaTime.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage ()
		{
			InitializeComponent (); 
        }
    }
}