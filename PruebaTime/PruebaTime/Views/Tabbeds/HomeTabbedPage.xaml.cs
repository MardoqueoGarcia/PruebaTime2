using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaTime.Views.Tabbeds
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			InitializeComponent ();
		}
	}
}