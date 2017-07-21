using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto4b_RelativeLayout
{
    public class RelativeLayoutExample : ContentPage
    {
        public RelativeLayoutExample()
        {
            RelativeLayout relativeLayout = new RelativeLayout();

            Label upperLeft = new Label
            {
                Text = "Upper Left",
                FontSize = 20
            };

            relativeLayout.Children.Add(upperLeft, Constraint.Constant(0), Constraint.Constant(0));

            Label below = new Label
            {
                Text = "Below Upper Left",
                FontSize = 15
            };

            relativeLayout.Children.Add(below, Constraint.Constant(0), Constraint.RelativeToView(upperLeft, (parent, sibling) =>
            {
                return sibling.Y + sibling.Height;
            }));

            Label constantLabel = new Label
            {
                Text = "Constant are Absolute",
                FontSize = 20,
                BackgroundColor = Color.AliceBlue
            };
            /* Add(nombreElemento, x, y, ancho, alto) */
            relativeLayout.Children.Add(constantLabel, Constraint.Constant(100), Constraint.Constant(100), Constraint.Constant(50), Constraint.Constant(200));

            Label halfWayDown = new Label
            {
                Text = "Un estado relativo al parent",
                FontSize = 15
            };
            relativeLayout.Children.Add(halfWayDown, Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 2;
            }), 
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Height / 2;
            }));

            BoxView boxview = new BoxView
            {
                Color = Color.Accent,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            relativeLayout.Children.Add(boxview, Constraint.Constant(10), Constraint.RelativeToParent((parent) =>
            {
                return parent.Height / 2;
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width / 2;
            }));

            Content = relativeLayout;
        }
    }
}