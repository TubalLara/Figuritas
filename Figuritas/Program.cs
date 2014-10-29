using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuritas
{
    class Program
    {
        static void Main(string[] args)
        {

            CrearFiguras ();
            var arr1 = new  [4];
            for (int i = 0; i < arr1.Length; i++)
            {
                
                Console.Write("Tipo de Figura: rectangulo o circulo");
                var tipo = (Console.ReadLine());
                if (tipo == "rectangulo")
                {
                    
                    arr1[i] = new Rectangulo();
                }
            }
           
            

        }
    }
}
