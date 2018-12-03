using Android.Widget;
using PruebaTime.Droid;
using PruebaTime.ViewModel.TabbedsViewModels;
using Xamarin.Forms;

[assembly:Dependency(typeof(Message_Droid))]
namespace PruebaTime.Droid
{
    public class Message_Droid : IMessage
    {
        public void LongTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }

        public void ShotrTime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}