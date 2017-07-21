using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto4d_ContentView
{
    public class ContentViewExample : ContentPage
    {
        public ContentViewExample()
        {
            Label label = new Label()
            {
                Text = "Una Label"
            };

            //BackgroundColor = Color.Black;

            //ContentView contentView = new ContentView
            //{
            //    BackgroundColor = Color.Teal,
            //    Padding = new Thickness(40),
            //    HorizontalOptions = LayoutOptions.Fill,
            //    Content = new StackLayout
            //    {
            //        Children =
            //        {
            //            label
            //        }
            //    }
            //};

            //Content = contentView;

            ContentView contentView = new ContentView
            {
                BackgroundColor = Color.Teal,
                Padding = new Thickness(40),
                HorizontalOptions = LayoutOptions.Fill,
                Content = new Label
                {
                    Text = "Podemos poner cualquier valor, StackLayout, View, Entry",
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White
                }
            };

            Padding = new Thickness(10);
            Content = new StackLayout
            {
                Children =
                {
                    contentView
                }
            };
            
        }
    }
}