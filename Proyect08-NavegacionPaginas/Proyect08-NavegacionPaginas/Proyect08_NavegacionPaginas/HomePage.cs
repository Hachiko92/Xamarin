using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Hierarchical Navigation";
            Label homeLabel = new Label
            {
                Text = "Home Page",
                FontSize = 40
            };

            Button homeButton = new Button { Text = "Go to the Second Page" };
            homeButton.Clicked += async (sender, args) =>
            {
                /* con PushAsync declara a que pagina tiene que ir */
                await Navigation.PushAsync(new SecondPage());
            };

            Button button = new Button { Text = "Show Alert" };
            /* cuando es async y se utiliza un displayAlert se utiliza 'e' 
             * en lugar de 'args' */
            button.Clicked += async (sender, e) =>
            {
                await DisplayAlert("ATENCION", "Descrubrir el valor de navegación", "OK");
            };

            Button button1 = new Button { Text = "Show Alert with FeedBack" };
            button1.Clicked += async (sender, e) =>
            {
                bool answer = await DisplayAlert("Start", "Estas dispuesta a seguir?", "SI", "NO");
            };

            Label label = new Label
            {
                Text = ""
            };
            Button button2 = new Button { Text = "Show ActionSheet" };
            button2.Clicked += async (sender, e) =>
            {
                string action = await DisplayActionSheet("Options", "Cancel", null, "Here", "There", "EveryWhere");
                label.Text = "Action is: " + action;
            };

            StackLayout stacklayout = new StackLayout()
            {
                Children =
                {
                    homeLabel,
                    homeButton,
                    button,
                    button1,
                    button2,
                    label
                }
            };

            Content = stacklayout;
        }
    }
}