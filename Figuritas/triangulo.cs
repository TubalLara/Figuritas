using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuritas
{
    public class Circulo:Figura
    {
        public static Double Pi = 3.14159;

        public Double Radio  { get; set;}
        
        public Circulo ()
        {
             
        }

        public Circulo(String nombre, Double nlados, Double pi, Double radio) : base(nombre, nlados)
        {
            Pi = pi;
            Radio = radio;
        }

        public override double Perimetro(Double pmt)
        {
            pmt = (Pi*Radio)*(Pi*Radio);
            return pmt;
        }

        public override double Area(double ar)
        {
            ar = 2*Pi*Radio;
            return ar;
        }
    }
}
