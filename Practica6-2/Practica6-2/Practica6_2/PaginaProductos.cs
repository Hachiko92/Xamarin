using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica6_2
{
    public class PaginaProductos : ContentPage
    {
        public PaginaProductos()
        {
            Title = "Listado de Productos";
            BackgroundColor = Color.White;

            ListView listview = new ListView();
            List<Producto> lista = Producto.getProductos();

            listview.ItemsSource = lista;

            listview.ItemTemplate = new DataTemplate(typeof(TextCell));
            listview.ItemTemplate.SetBinding(TextCell.TextProperty, new Binding("Codigo"));
            listview.ItemTemplate.SetBinding(TextCell.DetailProperty, new Binding("Nombre" + "\n" + "Precio"));
            //listview.ItemTemplate.SetBinding(TextCell.DetailProperty, new Binding("Precio" + "€"));

            listview.ItemTapped += async (sender, e) =>
            {
                Producto producto = e.Item as Producto;
                await DisplayAlert("Tapped", "Has seleccionado el producto: " + producto.Codigo, "OK");
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
                    listview
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