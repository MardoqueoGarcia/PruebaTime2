using Plugin.Media;
using PruebaTime.ViewModel.MasterViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Plugin.Media.Abstractions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using Plugin.Permissions;

namespace PruebaTime.ViewModel.CalculadoraVM
{
    public class CalculadoraViewModel : BaseViewModel
    {

        #region Constructor
        public CalculadoraViewModel()
        {
        }
        #endregion

        #region Attributes
        private Image image;
        #endregion

        #region Properties
        public Image Image
        {
            get { return image; }
            set { SetValue(ref this.image, value); }
        }
        #endregion

        #region Methods
        //Acceder a una foto
        public async void GetPhoto()
        {
            //if (!CrossMedia.Current.IsPickPhotoSupported)
            //{
            //    await App.Current.MainPage.DisplayAlert
            //        ("Alerta",
            //        "Foto no soportada.",
            //        "Ok");
            //    return;
            //}

            //var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            //{
            //    PhotoSize = PhotoSize.Medium,
            //});

            //if (file == null)
            //    return;

            //Image.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});
        }

        //Tomarse una foto
        public async void TakePhoto()
        {
            //Verificamos si tenemos permiso a la camara
            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync
                (Permission.Camera);

            var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync
                (Permission.Storage);

            //Si aun no tenemos permiso
            if (cameraStatus != PermissionStatus.Granted ||
                storageStatus != PermissionStatus.Granted)
            {
                var result = await CrossPermissions.Current.RequestPermissionsAsync
                    (new[]
                    {
                        Permission.Camera,
                        Permission.Storage
                    });

                cameraStatus = result[Permission.Camera];
                storageStatus = result[Permission.Storage];
            }

            //Si ya tenemos permiso
            if (cameraStatus == PermissionStatus.Granted &&
                storageStatus == PermissionStatus.Granted)
            {
                var files = await CrossMedia.Current.TakePhotoAsync
                    (new StoreCameraMediaOptions
                    {
                        Directory = "Sample",
                        Name = "Test"
                    });
            }

            else
            {
                await App.Current.MainPage.DisplayAlert("Alerta","Permiso denegado","Ok");
            }

            if (!CrossMedia.Current.IsCameraAvailable ||
                !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert
                    ("Alerta",
                    "Acceso a la camera denegado",
                    "Ok");
                return;
            }

            //var file = await CrossMedia.Current.TakePhotoAsync(
            //    new StoreCameraMediaOptions
            //    {
            //        Directory = "Test",
            //        SaveToAlbum = true,
            //        CompressionQuality = 75,
            //        CustomPhotoSize = 50,
            //        PhotoSize = PhotoSize.MaxWidthHeight,
            //        MaxWidthHeight = 2000,
            //        DefaultCamera = CameraDevice.Front
            //    });

            //if (file == null)
            //    return;

            //await App.Current.MainPage.DisplayAlert
            //        ("Localización",
            //        file.Path,
            //        "Ok");

            //Image.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});
        }
        #endregion


        #region Command
        public ICommand GetPhotoCommand
        {
            get
            {
                return new Command(GetPhoto);
            }
        }
        public ICommand TakePhotoCommand
        {
            get
            {
                return new Command(TakePhoto);
            }
        }
        #endregion
    }
}
