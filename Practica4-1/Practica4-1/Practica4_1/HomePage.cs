using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica4_1
{
    public class HomePage : ContentPage
    {
        string errColor = "#cd5c5c";
        string colorTexto = "#333333";
        string regExCharacter = @"^[a-zA-Z]+$";
        bool control = false; 
        public HomePage()
        {
            /* Entry por el Nombre */
            Entry nombreNacido = new Entry
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Nombre del recien nacido",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.Start
            };
            nombreNacido.TextChanged += (s, e) =>
            {
                control = Regex.IsMatch(nombreNacido.Text, regExCharacter);
                if (!control)
                    nombreNacido.TextColor = Color.Red;
                else
                    nombreNacido.TextColor = Color.Black;
            };

            /* DatePicker por la Fecha de Nacimiento */
            DatePicker fechaNacimiento = new DatePicker()
            {
                Format = "d",
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.Start,
                MaximumDate = DateTime.Today
            };

            /* TimePicker Por la hora de Nacimiento */
            TimePicker horaNacimiento = new TimePicker()
            {
                Format = "HH:mm",
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.Start
            };

            /* --- Gestion Slider Padre --- */
            Slider edadPadre = new Slider
            {
                Maximum = 99,
                Minimum = 14,
                Value = 30,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 400,
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.Start
            };

            Label lblPadre = new Label
            {
                Text = "La edad del padre es: 30",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };
            
            edadPadre.ValueChanged += (sender, e) =>
            {
                lblPadre.Text = "La edad del padre es: " + e.NewValue.ToString("#");
            };
            /* Fin gestion Slider Padre */

            /* --- Gestion Slider Madre ---*/
            Slider edadMadre = new Slider
            {
                Maximum = 55,
                Minimum = 14,
                Value = 30,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 400,
                Margin = new Thickness(0),
                VerticalOptions = LayoutOptions.Start
            };

            Label lblMadre = new Label
            {
                Text = "La edad de la madre es: 30",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            };

            edadMadre.ValueChanged += (sender, e) =>
            {
                lblMadre.Text = "La edad de la madre es: " + e.NewValue.ToString("#");
            };
            /* Fin gestion Slider Madre */

            /* Gestion secunda parte Formulario */
            Button btnAceptar = new Button()
            {
                Text = "ACEPTAR",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Label lblResultado = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.FromHex(colorTexto)
            };
            ContentView resultado = new ContentView()
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                Content = lblResultado,
                IsVisible = false
            };
            /* Fin gestion secunda parte Formulario */

            /* evento bóton */
            btnAceptar.Clicked += async (s, e) =>
            {
                if (nombreNacido.Text == (null) || nombreNacido.Text == "" || control == false)
                {
                    resultado.IsVisible = false;
                    nombreNacido.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    nombreNacido.BackgroundColor = Color.Default;
                    await Task.Delay(100);
                    nombreNacido.BackgroundColor = Color.FromHex(errColor);
                    await Task.Delay(100);
                    nombreNacido.BackgroundColor = Color.Default;
                }
                else
                {
                    /* Controles para que el usuario no inserte una hora del futuro */
                    if (fechaNacimiento.Date == DateTime.Today && Convert.ToDateTime(horaNacimiento.Time.ToString()) > DateTime.Now.ToLocalTime())
                    {
                        lblResultado.Text = "¿Es usted un viajador del tiempo?";
                        resultado.IsVisible = true;
                    }
                    else
                    {
                        /* no era posibile utilizar fechaNachimiento.Date.ToString() porque recogía la hora también, y sobre el DatePicker no era posibile utilizar .ToString("d") o un .ToShortDateString */
                        //var stringa = new FormattedString();
                        //stringa.Spans.Add(new Span { Text = nombreNacido.Text, FontAttributes = FontAttributes.Bold });
                        lblResultado.FormattedText = "Añadido " + nombreNacido.Text + ".\nNacido el " + (Convert.ToDateTime(fechaNacimiento.Date)).ToString("d") + " a las " + horaNacimiento.Time.ToString(@"hh\:mm") + " con padre de " + edadPadre.Value.ToString("#") + " años y madre de " + edadMadre.Value.ToString("#") + " años.";
                        resultado.IsVisible = true;
                    }
                }
            };

            StackLayout datos = new StackLayout()
            {
                Children =
                {
                    new Label
                    {
                        Text = "Registro de Nacimientos",
                        BackgroundColor = Color.Goldenrod,
                        TextColor = Color.White,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    nombreNacido,
                    new Label
                    {
                        Text = "Fecha de Nacimiento:",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    },
                    fechaNacimiento,
                    new Label
                    {
                        Text = "Hora de Nacimiento:",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    },
                    horaNacimiento,
                    lblPadre,
                    edadPadre,
                    lblMadre,
                    edadMadre,
                    btnAceptar,
                    resultado
                }
            }; // fin StackLayout datos

            //ContentView vista = new ContentView()
            //{
                
            //    Content = datos
            //};

            Content = new ScrollView()
            {
                Padding = new Thickness(40, 20, 40, 20),
                Content = datos
            };
        }
    }
}