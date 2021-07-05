using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tareafoto
{
    public partial class App : Application
    {
        static BaseDatos BD;

        public static BaseDatos InstanciaDB
        {
            get
            {
                if (BD == null)
                {
                    BD = new BaseDatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "archivo.db3"));
                }
                return BD;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
