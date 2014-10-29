using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuritas
{
    public class Rectangulo:Figura
    {

        public Double Altura { get; set; }

        public Double Ancho { get; set; }

        public Rectangulo()
        {
            
        }

        public Rectangulo(String nombre, Double nlados, Double altura, Double ancho) : base (nombre, nlados)
        {
            Altura = altura;
            Ancho = ancho;
        }

        public override double Area(double ar)
        {
            ar= Altura*Ancho;
            return ar;
        }

        public override double Perimetro(double pmt)
        {
            pmt = (2*Ancho)*(2*Altura);
            return pmt;
        }
    }
}
