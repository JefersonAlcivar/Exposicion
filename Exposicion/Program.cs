using System;
using System.Collections.Generic;

namespace Exposicion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figuras> ListaTotal = new List<Figuras>();


            Triangulo Figura1 = new Triangulo();
            Figura1.Base = 8;
            Figura1.Altura = 12;

            Cuadrado Figura2 = new Cuadrado();
            Figura2.Base = 6;

            Rectangulo Figura3 = new Rectangulo();
            Figura3.Base = 16;
            Figura3.Altura = 6;

            ListaTotal.Add(Figura1);
            ListaTotal.Add(Figura2);
            ListaTotal.Add(Figura3);

            // Usando el OPEN/CLOSED minimizamos el impacto de la modifiacion de 
            // codigo a tan solo dos lineas enseciales para la muestra de resultado

            Circulo_OPEN_CLOSE Figura4 = new Circulo_OPEN_CLOSE();
            ListaTotal.Add(Figura4);

            foreach (ICalcular figura in ListaTotal)
            {
                figura.calcular_area();
            }
        }
    }
}
