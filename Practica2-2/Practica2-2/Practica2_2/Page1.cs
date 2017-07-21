using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica2_2
{
    public class Page1 : ContentPage
    {
        string errColor = "#cd5c5c";
        string btnColor = "#333333";
        public Page1()
        {
            decimal division;
            Entry numero1 = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Placeholder = "Primer Número",
                PlaceholderColor = Color.FromHex("#333333")
            };

            Entry numero2 = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Placeholder = "Segundo Número",
                PlaceholderColor = Color.FromHex("#333333")
            };

            Button sumar = new Button()
            {
                BackgroundColor = Color.FromHex(btnColor),
                TextColor = Color.White,
                Text = "+",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };

            Button restar = new Button()
            {
                BackgroundColor = Color.FromHex(btnColor),
                TextColor = Color.White,
                Text = "-",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };

            Button moltiplicar = new Button()
            {
                BackgroundColor = Color.FromHex(btnColor),
                TextColor = Color.White,
                Text = "*",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };

            Button dividir = new Button()
            {
                BackgroundColor = Color.FromHex(btnColor),
                TextColor = Color.White,
                Text = "/",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button))
            };

            sumar.Clicked += async (s, e) =>
            {
                if(numero1.Text == (null))
                {
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                }
                else
                {
                    if(numero2.Text == (null))
                    {
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                    }
                    else
                    {
                        sumar.Text = (Convert.ToDecimal(numero1.Text) + Convert.ToDecimal(numero2.Text)).ToString();
                    }
                }
            };

            restar.Clicked += async (s, e) =>
            {
                if (numero1.Text == (null))
                {
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                }
                else
                {
                    if (numero2.Text == (null))
                    {
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                    }
                    else
                    {
                        restar.Text = (Convert.ToDecimal(numero1.Text) - Convert.ToDecimal(numero2.Text)).ToString();
                    }
                }
            };

            moltiplicar.Clicked += async (s, e) =>
            {
                if (numero1.Text == (null))
                {
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                }
                else
                {
                    if (numero2.Text == (null))
                    {
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                    }
                    else
                    {
                        moltiplicar.Text = (Convert.ToDecimal(numero1.Text) * Convert.ToDecimal(numero2.Text)).ToString();
                    }
                }
            };

            dividir.Clicked += async (s, e) =>
            {
                if (numero1.Text == (null))
                {
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                    numero1.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    numero1.BackgroundColor = Color.Default;
                }
                else
                {
                    if (numero2.Text == (null) || Convert.ToInt32(numero2.Text) == 0)
                    {
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                        numero2.BackgroundColor = Color.FromHex(errColor);
                        await Task.Delay(100);
                        numero2.BackgroundColor = Color.Default;
                    }
                    else
                    {
                        division = Convert.ToDecimal(numero1.Text) / Convert.ToDecimal(numero2.Text);
                        dividir.Text = Math.Round(division, 2).ToString();
                    }
                }
            };

            StackLayout botones1 = new StackLayout
            {
                Children =
                {
                    sumar,
                    restar
                },

                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout botones2 = new StackLayout
            {
                Children =
                {
                    moltiplicar,
                    dividir
                },

                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            StackLayout all = new StackLayout
            {
                Children =
                {
                    numero1, numero2,
                    botones1, botones2
                }
            };

            Content = all;
        }
    }
}