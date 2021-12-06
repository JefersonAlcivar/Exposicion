using System;
using System.Collections.Generic;
using System.Text;

namespace Exposicion
{
    class Triangulo : Figuras, ICalcular
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public void calcular_area ()
        {
            int Total = (Base * Altura) / 2;
            Console.WriteLine(" El Area del Triangulo es = " + Total);
        }
       
    }
}
