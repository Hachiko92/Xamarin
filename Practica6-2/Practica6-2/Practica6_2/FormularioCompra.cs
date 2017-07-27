using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica6_2
{
    public class FormularioCompra : ContentPage
    {
        public FormularioCompra()
        {
            Title = "Formulario de Compra";

            Entry producto = new Entry
            {
                Placeholder = "Clave Producto",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            Entry cliente = new Entry
            {
                Placeholder = "Nombre Cliente",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            Entry direccion = new Entry
            {
                Placeholder = "Direccion de Entrega",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            /* Bóton */
            Button aceptarButton = new Button
            {
                Text = "ACEPTAR",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            aceptarButton.Clicked += async (sender, e) =>
            {
                bool control = false;
                var lista = Producto.getProductos();
                foreach(var codigo in lista)
                {
                    if (codigo.Codigo == producto.Text)
                        control = true;
                }

                if (control == true)
                {
                    string action = await DisplayActionSheet("Formas de pago", "Canell", null, "Tarjeta", "Efectivo", "Compra a plazos");
                    bool compra = await DisplayAlert("Aceptar Compra", "Proceder con la compra?", "SI", "NO");
                    if (compra)
                    {
                        await Navigation.PushAsync(new Compra(producto.Text, cliente.Text, direccion.Text, action));
                    }
                }
                else
                {
                    await DisplayAlert("Error", "No se ha encontrado el producto seleccionado", "OK");
                }
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
                    producto, cliente, direccion,
                    aceptarButton
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