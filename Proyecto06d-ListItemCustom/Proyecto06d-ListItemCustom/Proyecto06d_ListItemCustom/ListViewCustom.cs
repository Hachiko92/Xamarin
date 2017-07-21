using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto06d_ListItemCustom
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

            //listview.ItemTemplate = new DataTemplate(typeof());
        }
    }
}