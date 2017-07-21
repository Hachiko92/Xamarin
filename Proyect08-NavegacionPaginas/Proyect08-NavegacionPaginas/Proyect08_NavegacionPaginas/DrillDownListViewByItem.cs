using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class DrillDownListViewByItem : ContentPage
    {
        public DrillDownListViewByItem()
        {
            Title = "DrillDown Using ListView";
            var listview = new ListView();
            listview.ItemsSource = new ListItem[]
            {
                new ListItem {Title = "First", Description = "1st Item" },
                new ListItem {Title = "Second", Description = "2nd Item" },
                new ListItem {Title = "Third", Description = "3rd Item" }
            };

            listview.ItemTemplate = new DataTemplate(typeof(TextCell));
            listview.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            //listview.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");
            listview.ItemTapped += async (sender, e) =>
            {
                var item = e.Item as ListItem;
                if (item == null) return;
                await Navigation.PushAsync(new DetailsPage(item));
                listview.SelectedItem = null;
            };

            Content = listview;


        }
    }
}