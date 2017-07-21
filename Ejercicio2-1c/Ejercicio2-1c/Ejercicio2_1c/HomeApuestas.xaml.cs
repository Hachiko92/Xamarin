using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio2_1c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeApuestas : ContentPage
    {
        public HomeApuestas()
        {
            InitializeComponent();

            var minus = new TapGestureRecognizer();

            minus.Tapped += (s, e) =>
            {
                if (Convert.ToInt32(lblApuesta.Text) != 10)
                {
                    lblApuesta.Text = (Convert.ToInt32(lblApuesta.Text) - 10).ToString();
                }
            };

            imgMinus.GestureRecognizers.Add(minus);

            var plus = new TapGestureRecognizer();

            plus.Tapped += (s, e) =>
            {
                lblApuesta.Text = (Convert.ToInt32(lblApuesta.Text) + 10).ToString();
            };

            imgPlus.GestureRecognizers.Add(plus);

            btnApostar.Clicked += async (s, e) =>
            {
                if (username.Text == (null) || username.Text == "")
                {
                    username.BackgroundColor = Color.IndianRed;
                    await Task.Delay(200);
                    username.BackgroundColor = Color.Green;
                    await Task.Delay(50);
                    username.BackgroundColor = Color.IndianRed;
                    await Task.Delay(200);
                    username.BackgroundColor = Color.Green;
                }
                else
                {
                    lblUsuario.Text = username.Text;
                    lblEuro.Text = lblApuesta.Text;
                }
            };
        }
    }
}