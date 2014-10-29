using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuritas
{
    public abstract class Figura
    {
        public String Nombre { get; set; }

        public double Nlados { get; set; }
    

        public Figura ()
        {
             
        }

       
        public Figura (String nombre, Double nlados)
        {
            Nombre = nombre;
            Nlados = nlados;
        }

        public abstract double Perimetro(Double pmt);

        public abstract double Area(Double ar);



    }
}
