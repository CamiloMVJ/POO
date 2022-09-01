using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletas
{
    public class Boleta
    {
        //Atributos
        public String? Cliente { get; set; }
        public int NumBoleta { get; set; }
        public String? Direccion { get; set; }
        public String? DNI { get; set; }
        public DateTime FechaCompra { get; set; }
        public String? Producto { get; set; }
        public int Cantidad { get; set; }

        //Metodos

        public double Precio()
        {
            switch (this.Producto)
            {
                case "PS5+ 1 MANDO DS5": return 500;
                case "PS4 (1TB) + 1 MANDO DS4": return 619;
                case "MANDO PS5/DS5": return 69;
                case "MANDO PS4/DS4": return 60;
            }
            return 0;
        }
        public double Importe()
        {
            return Precio() * this.Cantidad;
        }


    }
}
