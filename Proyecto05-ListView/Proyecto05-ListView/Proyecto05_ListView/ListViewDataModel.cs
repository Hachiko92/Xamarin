using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto05_ListView
{
    public class ListViewDataModel : ContentPage
    {
        public ListViewDataModel()
        {
            var listview = new ListView();
            listview.ItemsSource = new ListItem[]
            {
                new ListItem {Title = "Primero", Description = "Primer elemento" },
                new ListItem {Title = "Sengundo", Description = "Segundo elemento" },
                new ListItem {Title = "Tercero", Description = "Tercer elemento" },
            };

            /* declara que en el listview va a aparecer solo texto */
            listview.ItemTemplate = new DataTemplate(typeof(TextCell));
            /* Para declarar desde donde debe recoger el titulo (la clase ListItem.cs 
             * tiene una propiedad de tipo stringa que le llama "Title") */
            listview.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            /* Para declarar la descripcion */
            listview.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");

            listview.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("TAPPED", e.Item.ToString() + " elemento tapeado", "OK");
                /* Para que el elemento seleccionado no se quede seleccionado */
                ((ListView)sender).SelectedItem = null;
            };

            Content = listview;
        }
    }
}