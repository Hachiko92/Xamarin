using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto02_Entry
{
    public class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            Entry entry = new Entry()
            {
                Placeholder = "Introduce tu DNI",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Default
            };

            Image image = new Image
            {
                Source = "png.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill
            };

            var tapGestureRecognizer = new TapGestureRecognizer();

            /* async porque se costruye pero no está utilizado enseguida,
             * espera que alquien lo llame */
            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                image.Opacity = .5;
                await Task.Delay(200);
                image.Opacity = 1;
            };

            image.GestureRecognizers.Add(tapGestureRecognizer);

            BoxView boxView = new BoxView
            {
                Color = Color.Silver,
                //WidthRequest = 150,
                HeightRequest = 15000,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            StackLayout Contenedor = new StackLayout
            {
                Children =
                {
                    entry,
                    image,
                    boxView
                },
                HeightRequest = 1500
            };

            ScrollView scrollview = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = Contenedor
            };

            Content = scrollview;
        }
    }
}