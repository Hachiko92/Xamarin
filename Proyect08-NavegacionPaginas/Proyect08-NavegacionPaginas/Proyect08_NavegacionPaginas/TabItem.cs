using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect08_NavegacionPaginas
{
    public class TabItem
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public TabItem(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
