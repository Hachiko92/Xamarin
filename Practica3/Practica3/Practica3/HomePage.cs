using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica3
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Grid grid = new Grid()
            {
                BackgroundColor = Color.PaleGoldenrod,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star)}
                },
                ColumnSpacing = 3,
                RowSpacing = 3,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            grid.Children.Add(new Label
            {
                Text = "USUARIO:",
                FontSize = 20,
                VerticalTextAlignment = TextAlignment.Center
            }, 0, 0);
            grid.Children.Add(new Label
            {
                Text = "DIRECCION:",
                FontSize = 20,
                VerticalTextAlignment = TextAlignment.Center
            }, 0, 1);

            grid.Children.Add(new Entry
            {
                Placeholder = "Nombre Usuario",
                FontSize = 25
            }, 1, 0);
            grid.Children.Add(new Entry
            {
                Placeholder = "Dirección",
                FontSize = 25
            }, 1, 1);

            grid.Children.Add(new Button
            {
                Text = "ACEPTAR",
                BackgroundColor = Color.MediumBlue,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center
            }, 0, 2);
            grid.Children.Add(new Button
            {
                Text = "CANCELAR",
                BackgroundColor = Color.MediumBlue,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center
            }, 1, 2);

            Padding = new Thickness(10);
            Content = grid;
        }
    }
}