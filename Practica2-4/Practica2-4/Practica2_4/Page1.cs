using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica2_4
{
    public class Page1 : ContentPage
    {
        string pw = "gatto";
        public Page1()
        {
            Label titulo = new Label
            {
                Text = "FORMULARIO DE VALIDACCION",
                BackgroundColor = Color.DarkOrange,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Entry username = new Entry
            {
                Placeholder = "Username",
                BackgroundColor = Color.DarkOrange,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Keyboard = Keyboard.Default,
                FontSize = 20
            };

            Entry password = new Entry
            {
                Placeholder = "Password",
                BackgroundColor = Color.DarkOrange,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Keyboard = Keyboard.Default,
                IsPassword = true,
                FontSize = 20
            };

            Button btnAceptar = new Button()
            {
                Text = "ACEPTAR",
                BackgroundColor = Color.FromHex("#333333"),
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                WidthRequest = 150
            };

            Button btnCancelar = new Button()
            {
                Text = "CANCELAR",
                BackgroundColor = Color.FromHex("#333333"),
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                WidthRequest = 150
            };

            Image skull = new Image
            {
                Source = "skull.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                IsVisible = false,
                Margin = new Thickness(10)
            };

            btnAceptar.Clicked += async (s, e) =>
            {
                if (password.Text == pw)
                {
                    skull.IsVisible = true;
                }
                else
                {
                    password.BackgroundColor = Color.IndianRed;
                    await Task.Delay(100);
                    password.BackgroundColor = Color.DarkOrange;
                    password.Text = "";
                }
            };

            btnCancelar.Clicked += (s, e) =>
            {
                username.Text = "";
                password.Text = "";
                skull.IsVisible = false;
            };

            StackLayout botones = new StackLayout()
            {
                Children =
                {
                    btnAceptar, btnCancelar
                },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    titulo,
                    username,
                    password,
                    botones,
                    skull
                }
            };

            ScrollView scrollView = new ScrollView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout
            };
            
            Content = scrollView;
        }
    }
}