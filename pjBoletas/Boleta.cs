using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletas
{
    internal class Boleta
    {
        //Atributos
        public String cliente { get; set; }
        public String direccion { get; set; }
        public DateTime fechaCompra { get; set; }
        public String DNI { get; set; }
        public String producto { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }


        //Metodos

        public double Precio()
        {
            return this.precio;
        }

        public double importe()
        {
            return this.precio * this.cantidad;
        }

    }
}
