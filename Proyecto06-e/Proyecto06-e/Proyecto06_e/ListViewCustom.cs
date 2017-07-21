using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto06_e
{
    public class ListViewCustom : ContentPage
    {
        public ListViewCustom()
        {
            var listview = new ListView();
            listview.ItemsSource = new ListItemCustom[]
            {
                new ListItemCustom {Title = "Primero", Description = "Primer Custom", Price = "$100.00" },
                new ListItemCustom {Title = "Segundo", Description = "Segundo Custom", Price = "$200.00" },
                new ListItemCustom {Title = "Tercero", Description = "Tercer Custom", Price = "$300.00" }
            };
            listview.RowHeight = 80;
            listview.BackgroundColor = Color.Black;

            /* la plantilla de listview será como la hemos declarada en ListItemCell */
            listview.ItemTemplate = new DataTemplate(typeof(ListItemCell));

            listview.ItemTapped += async (sender, e) =>
            {
                ListItemCustom item = (ListItemCustom)e.Item;
                await DisplayAlert("TAPPED", item.Price.ToString() + " elemento tapeado", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Content = listview;
        }
    }
}