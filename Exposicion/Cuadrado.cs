using System;
using System.Collections.Generic;
using System.Text;

namespace Exposicion
{
    class Cuadrado : Figuras, ICalcular
    {
        public int Base { get; set; }
        

        public void calcular_area()
        {
            int Total = Base * 4;
            Console.WriteLine(" El Area del Cuadrado es = " + Total);
        }
    }
}
