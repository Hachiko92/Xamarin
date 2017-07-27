using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica6_2
{
    public class Compra : ContentPage
    {
        public Compra(string codigo, string cliente, string direccion, string action)
        {
            Title = "Compras Online";

            Label resumen = new Label
            {
                Text = "CLAVE PRODUCTO: " + codigo + "\nNOMBRE CLIENTE: " + cliente + "\nDIRECCION DE ENTREGA: " + direccion,

            };

            Button atrasButton = new Button
            {
                Text = "ATRAS",
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stacklayout = new StackLayout()
            {
                Children =
                {
                    new Image
                    {
                        Source = "logo.png",
                        Aspect = Aspect.AspectFit,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Start,
                        Margin = new Thickness(0, 40, 0, 40)
                    },
                    resumen
                }
            };


            Content = new ContentView
            {
                Padding = new Thickness(20, 0, 20, 0),
                Content = stacklayout
            };
        }
    }
}