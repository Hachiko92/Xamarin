using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto05_ListView
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            ListView listview = new ListView();
            List<string> lista = new List<string>()
            {
                "Primero",
                "Secundo",
                "Tercero"
            };
            listview.ItemsSource = lista;

            //listview.ItemTapped += async (sender, e) =>
            //{
            //    await DisplayAlert("TAPPED", e.Item.ToString() + " elemento tapeado", "OK");
            //    /* Para que el elemento seleccionado no se quede seleccionado */
            //    ((ListView)sender).SelectedItem = null;
            //};

            listview.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                await DisplayAlert("SELECTED", e.SelectedItem.ToString() + " elemento seleccionado", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            /* Device.OnPlatfrom(iOS, Android, Windows) */
            //Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = listview;
        }
    }
}