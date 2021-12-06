using System;
using System.Collections.Generic;
using System.Text;

namespace Exposicion
{
    class Circulo_OPEN_CLOSE : Figuras , ICalcular //Una manera simple y efectiva para poner el practica este principio es usar 
                                                   //interfaces y así delegar la funcionalidad a los objetos de que implementan.

    {
        public int Radio { get; set; }
        public double Pi { get; set; }

        public void calcular_area()
        {
            //Agregaremos los valores directamente en nuestra clase 
            //para asi evitar modificar el codigo 
            Pi = 3.14;
            Radio = 13;
            double Total = Pi * (Radio*Radio);
            Console.WriteLine(" El Area del Circulo es = " + Total);
        }
    }
}
