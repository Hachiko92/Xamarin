using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto06c_ListViewImage
{
    public class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            var listview = new ListView();
            listview.ItemsSource = new ListItemImages[]
            {
                new ListItemImages { source = "icon.png", title = "Primero", description = "Primera imagen" },
                new ListItemImages { source = "icon.png", title = "Segundo", description = "Segunda imagen" },
                new ListItemImages { source = "icon.png", title = "Tercero", description = "Tercera imagen" },
            };

            listview.ItemTemplate = new DataTemplate(typeof(ImageCell));
            listview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "source");
            listview.ItemTemplate.SetBinding(ImageCell.TextProperty, "title");
            listview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "description");

            listview.ItemTapped += async (sender, e) =>
            {
                ListItemImages item = (ListItemImages)e.Item;
                await DisplayAlert("TAPPED", item.ToString() + " elemento tapeado", "OK");
                /* Para que el elemento seleccionado no se quede seleccionado */
                ((ListView)sender).SelectedItem = null;
            };

            Padding = new Thickness(10, 0, 10, 5);
            Content = listview;
        }
    }
}