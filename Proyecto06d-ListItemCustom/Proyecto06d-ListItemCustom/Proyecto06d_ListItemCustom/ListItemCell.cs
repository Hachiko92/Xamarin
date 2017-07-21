using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto06d_ListItemCustom
{
    public class ListItemCell : ViewCell
    {
        public ListItemCell()
        {
            Label titleLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White
            };

            titleLabel.SetBinding(Label.TextProperty, "Title");

            Label descLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 12,
                TextColor = Color.White
            };
            descLabel.SetBinding(Label.TextProperty, "Description");

            StackLayout viewLayoutItem = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    titleLabel,
                    descLabel
                }
            };

            Label priceLabel = new Label
            {
                HorizontalOptions = LayoutOptions.End,
                FontSize = 12,
                TextColor = Color.Aqua
            };
            priceLabel.SetBinding(Label.TextProperty, "Price");

            var button = new Button()
            {
                Text = "Comprar ahora",
                BackgroundColor = Color.Teal,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            
            button.SetBinding(Button.CommandParameterProperty, new Binding("."));
            button.Clicked += (sender, e) =>
            {

            };
        }
    }
}