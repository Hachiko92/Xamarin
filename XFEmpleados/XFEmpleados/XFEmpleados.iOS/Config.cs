using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SQLite.Net.Interop;
using Xamarin.Forms;

//Dependency : servicio que nos permite tener compatibiidad en las tres plataformas
[assembly: Dependency(typeof(XFEmpleados.iOS.Config))]
namespace XFEmpleados.iOS
{
    class Config : IConfig
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;
        public string DirectorioDB
        {//obtenemos el directorio en IOS
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    var directorio = System.Environment.GetFolderPath(
                        Environment.SpecialFolder.Personal);
                    directorioDB = System.IO.Path.Combine(directorio, "..", "Library");
                }
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {//Obtenemos la plataforma en IOS
            get
            {
                if (plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return plataforma;
            }
        }
    }
}