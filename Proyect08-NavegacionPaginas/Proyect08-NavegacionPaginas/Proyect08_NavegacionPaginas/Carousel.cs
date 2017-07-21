using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class Carousel : CarouselPage
    {
        public Carousel()
        {
            Children.Add(new FirstPage());
            Children.Add(new SecondPage());
            Children.Add(new ThirdPage());
        }
    }
}