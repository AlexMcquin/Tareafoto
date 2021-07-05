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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaImagenes : ContentPage
    {
        public ListaImagenes()
        {
            InitializeComponent();
        }
        Imagenes itemImagenes = new Imagenes();

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                ListaIMG.ItemsSource = await App.InstanciaDB.ObtenerImagen();
            }
            catch (Exception ex)
            {

            }
        }

        private async  void ListaImagenes_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            itemImagenes = (Imagenes)e.Item;

            var jpg = itemImagenes.Content;
            var nombre = itemImagenes.FileName;
            var descripcion = itemImagenes.Descripcion;
            await Navigation.PushAsync(new ImageScreen(jpg, nombre, descripcion));




        }
    }
}