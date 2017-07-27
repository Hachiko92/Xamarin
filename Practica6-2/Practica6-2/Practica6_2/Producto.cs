using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6_2
{
    class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }

        static public List<Producto> getProductos()
        {
            List<Producto> lista = new List<Producto>();

            lista.Add(new Producto { Codigo = "X65", Nombre = "HP double nucleo", Precio = 545f });
            lista.Add(new Producto { Codigo = "XM23", Nombre = "HP pavillion 65", Precio = 654.5f });
            lista.Add(new Producto { Codigo = "XN32", Nombre = "HP 76 HD-SOLID", Precio = 760.9f });

            return lista;
        }
    }
}
