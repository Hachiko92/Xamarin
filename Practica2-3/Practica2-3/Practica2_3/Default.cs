using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica2_3
{
    public class Default : ContentPage
    {
        public Default()
        {
            Image skull = new Image()
            {
                Source = "skull.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                Opacity = .5
            };

            Button btnAumentar = new Button
            {
                BackgroundColor = Color.FromHex("#333333"),
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                IsVisible = false,
                Text = "Aumentar"
            };

            Button btnDesminuir = new Button
            {
                BackgroundColor = Color.FromHex("#333333"),
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                IsVisible = false,
                Text = "Desminuir"
            };

            var clickFoto = new TapGestureRecognizer();

            clickFoto.Tapped += (s, e) =>
            {
                if(btnAumentar.IsVisible == false && btnDesminuir.IsVisible == false)
                {
                    btnAumentar.IsVisible = true;
                    btnDesminuir.IsVisible = true;
                }
            };

            skull.GestureRecognizers.Add(clickFoto);

            btnAumentar.Clicked += (s, e) =>
            {
                if(skull.Opacity != 1)
                {
                    skull.Opacity += .1;

                    if(skull.Opacity == 1)
                    {
                        btnAumentar.IsVisible = false;
                    }
                    if (btnDesminuir.IsVisible == false)
                    {
                        btnDesminuir.IsVisible = true;
                    }
                }
            };

            btnDesminuir.Clicked += (s, e) =>
            {
                if (skull.Opacity != 0)
                {
                    skull.Opacity -= .1;

                    if (skull.Opacity == 0)
                    {
                        btnDesminuir.IsVisible = false;
                    }
                    if (btnAumentar.IsVisible == false)
                    {
                       btnAumentar.IsVisible = true;
                    }
                }
            };

            StackLayout botones = new StackLayout
            {
                Children =
                {
                    btnAumentar,
                    btnDesminuir
                },

                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            Content = new StackLayout
            {
                Children = {
                    skull,
                    botones
                }
            };
        }
    }
}