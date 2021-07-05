using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tareafoto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void toma_Clicked(object sender, EventArgs e)
        {
            // var tomarfoto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions());

            var tomarfoto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "MiApp",
                Name = "Prueba.jpg",
                SaveToAlbum = true
            });

            await DisplayAlert("Ubicacion Archivo", tomarfoto.Path, "OK");

            byte[] imageArray = null;




            //Insercion de mapa de bytes
            using (MemoryStream memory = new MemoryStream())
            {

                Stream stream = tomarfoto.GetStream();
                stream.CopyTo(memory);
                imageArray = memory.ToArray();
            }







            await Navigation.PushAsync(new SaveScreen(imageArray));

            //var CompartirFoto = tomarfoto.Path;
            //await Share.RequestAsync(new ShareFileRequest
            //{
            //    Title = "Foto",
            //    File = new ShareFile(CompartirFoto)
            //}); 


        }
        private async void listaImagenes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaImagenes());



        }


    }
}
