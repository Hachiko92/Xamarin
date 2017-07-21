using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto4e_FramePage
{
    public class FramePageExample : ContentPage
    {
        public FramePageExample()
        {
            BackgroundColor = Color.LightCoral;
            Padding = 20;
            Content = new Frame
            {
                Content = new StackLayout
                {
                    Spacing = 13,
                    Children = { new Label { Text = "Cuadro", FontSize = 20 } }
                },
                OutlineColor = Color.Blue
            };
        }
    }
}