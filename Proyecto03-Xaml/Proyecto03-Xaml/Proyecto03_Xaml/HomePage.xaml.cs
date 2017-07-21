using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto03_Xaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            boton.Clicked += (sender, args) =>
            {
                boton.Text = "It is So!";
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                image.Opacity = .5;
                await Task.Delay(200);
                image.Opacity = 1;
            };

            image.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}