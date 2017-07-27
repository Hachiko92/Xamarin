using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica6_2
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Compras OnLine";
            BackgroundColor = Color.White;

            /* variables globales */

            /* Menú */
            ToolbarItems.Clear();

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Productos",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new PaginaProductos()))
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Formulario Compra",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new FormularioCompra()))
            });

            /* Content */
            Content = new ContentView
            {
                Padding = new Thickness(20, 0, 20, 0),
                /* Logo */
                Content = new Image
                {
                    Source = "logo.png",
                    Aspect = Aspect.AspectFit,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Start,
                    Margin = new Thickness(0, 40, 0, 40)
                }
            };
        }
    }
}