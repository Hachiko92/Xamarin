using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto07_Grouped
{
    public class ListViewGrouped : ContentPage
    {
        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public class Group : List<ListItem>
        {
            public string Key { get; private set; }
            public Group(string key, List<ListItem> items)
            {
                Key = key;
                foreach (var item in items)
                    Add(item);
            }
        }

        public ListViewGrouped()
        {
            List<Group> itemGrouped = new List<Group>
            {
                new Group("Important", new List<ListItem>
                {
                    new ListItem {Title = "Primero", Description = "1st item" },
                    new ListItem {Title = "Segundo", Description = "2nd item" },
                }),
                new Group("Less Important", new List<ListItem>
                {
                    new ListItem {Title = "Tercero", Description = "3rd item" }
                })
            };

            ListView listview = new ListView()
            {
                /* IsGroupingEnabled sirve para hacer grupos */
                IsGroupingEnabled = true,
                /* GroupDisplayBinding sirve para declarar sombre que 
                 * valor hay que bindear */
                GroupDisplayBinding = new Binding("Key"),
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings =
                    {
                        { TextCell.TextProperty, new Binding("Title") },
                        /* La descripción se podria poner como TextProperty
                         * pero graficamente sería igual al Title */
                        { TextCell.DetailProperty, new Binding("Title") }
                    }
                }
            };

            listview.ItemsSource = itemGrouped;

            Content = listview;
            Padding = new Thickness(0, 20, 0, 0);
        }
    }
}