using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class DrillDownListViewByPage : ContentPage
    {
        public class ListItemPage
        {
            public string Title { get; set; }
            /* Type define el tipo de pagina (contentPage etc) */
            public Type pageType { get; set; }
        }
        public DrillDownListViewByPage()
        {
            Title = "DrillDown List Using ListView by page";

            var listview = new ListView();
            listview.ItemsSource = new ListItemPage[]
            {
                new ListItemPage {Title = "First", pageType = typeof(FirstPage)},
                new ListItemPage {Title = "Second", pageType = typeof(SecondPage)},
                new ListItemPage {Title = "Third", pageType = typeof(ThirdPage)}
            };
            listview.ItemTemplate = new DataTemplate(typeof(TextCell));
            listview.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listview.ItemTapped += async (sender, e) =>
            {
                var item = e.Item as ListItemPage;
                if (item == null) return;
                Page page = (Page)Activator.CreateInstance(item.pageType);
                await Navigation.PushAsync(page);
                listview.SelectedItem = null;
            };

            Content = listview;
        }
    }
}