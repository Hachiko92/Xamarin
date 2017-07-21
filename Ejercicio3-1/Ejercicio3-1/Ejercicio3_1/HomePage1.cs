using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ejercicio3_1
{
    public class HomePage1 : ContentPage
    {
        public HomePage1()
        {
            Padding = new Thickness(10);

            Label titulo = new Label
            {
                Text = "BET365",
                TextColor = Color.Yellow,
                FontSize = 25,
                FontAttributes = FontAttributes.Bold
            };

            Label subtitulo = new Label
            {
                Text = "La casa de aspuestas por Internet",
                TextColor = Color.Yellow,
                FontSize = 20
            };

            Entry username = new Entry
            {
                Placeholder = "Username",
                BackgroundColor = Color.White,
                Margin = new Thickness(0),
                PlaceholderColor = Color.Black
            };

            Entry password = new Entry
            {
                Placeholder = "Password",
                BackgroundColor = Color.White,
                Margin = new Thickness(0),
                PlaceholderColor = Color.Black
            };

            Button aceptar = new Button()
            {
                Text = "ACEPTAR",
                BackgroundColor = Color.Green,
                TextColor = Color.Yellow,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };

            StackLayout credenziali = new StackLayout()
            {
                BackgroundColor = Color.White,
                Children =
                {
                    username,
                    password,
                    new ContentView
                    {
                        BackgroundColor = Color.Yellow,
                        Padding = new Thickness(2),
                        Content = aceptar
                    }
                }
            };

            StackLayout login = new StackLayout()
            {
                Children =
                {
                    titulo,
                    subtitulo,
                    credenziali
                }
            };

            ContentView contentView = new ContentView()
            {
                Padding = new Thickness(40),
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.Fill,
                Content = login
            };

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