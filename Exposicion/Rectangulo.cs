using System;
using System.Collections.Generic;
using System.Text;

namespace Exposicion
{
    class Rectangulo : Figuras, ICalcular
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public void calcular_area()
        {
            int Total = Base * Altura;
            Console.WriteLine(" El Area del Rectangulo es = " + Total);
        }
    }
}
