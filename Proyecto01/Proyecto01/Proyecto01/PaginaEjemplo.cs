using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto01
{
    public class PaginaEjemplo : ContentPage
    {
        public PaginaEjemplo()
        {
            /* aqui solo está definida la etiqueta */
            Label labelGrande = new Label()
            {
                Text = "Label Grande",
                FontSize = 40,
                BackgroundColor = Color.FromHex("#333333"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Center
            };

            Label labelPequeña = new Label()
            {
                Text = "Este control va a trabajar\n" +
                       "en varias lineas de\n" +
                       "texto",
                FontFamily = "Courier",
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            /* por la dimension del texto de un botón se utiliza si o si Device.GetNamedSize() */
            Button button = new Button
            {
                Text = "Presioname",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            /* Opcion más sencilla para capturar el evento del click en el botón */
            button.Clicked += (sender, args) =>
            {
                button.Text = "Ya me has presionado";
            };

            /* el StackLayout puede contener solo un children pero dentro el children se puede poner 
             * uno stackLayout (o más) que a su vez tiene las mismas leyes */
            StackLayout stackLayout = new StackLayout
            {
                /* Children es la colleción de hijos que tiene el contenedor (StackLayout) */
                Children =
                {
                    labelGrande,
                    labelPequeña,
                    button
                }
            };

            /* pasa a la propiedad Content (para definir el contenido de 
             * "ContentPage") el contenido de la pagina */
            /* A el content solo se puede asignar uno StackLayout */
            Content = stackLayout;
        }
    }
}