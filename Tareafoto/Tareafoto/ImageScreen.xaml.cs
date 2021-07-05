using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tareafoto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageScreen : ContentPage
    {
        public ImageScreen(Byte[] imagen, String nombre, String descripcion)
        {
            InitializeComponent();



            imageView.Source = ImageSource.FromStream(() => new MemoryStream(imagen));

            Nombre.Text = nombre;
            Descripcion.Text = descripcion;
        }
    }
}