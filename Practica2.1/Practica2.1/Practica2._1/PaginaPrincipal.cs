using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica2._1
{
    public class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            int marginTop = 3;

            Label lblNombre = new Label()
            {
                Text = "Nombre",
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.FromHex("#333")
            };

            Label lblApellidos = new Label()
            {
                Text = "Apellidos",
                FontSize = lblNombre.FontSize,
                HorizontalOptions = LayoutOptions.Center
            };

            Button boton = new Button
            {
                Text = "CONCATENAR",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                TextColor = Color.White,
                BackgroundColor = Color.LightBlue,
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, marginTop, 0, 0)
            };

            boton.Clicked += (sender, args) =>
            {
                boton.Text = lblNombre.Text + " " + lblApellidos.Text;
                lblNombre.IsVisible = false;
                lblApellidos.IsVisible = false;
                boton.Margin = new Thickness(0, Convert.ToInt32(lblNombre.Height + lblApellidos.Height) + 3, 0, 0);
            };

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    lblNombre,
                    lblApellidos,
                    boton
                }
            };

            Content = stackLayout;
        }
    }
}