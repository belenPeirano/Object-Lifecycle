//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            int h = 10000000;
            for (int i = 1; i <= h; i++)
            {
                string m = i.ToString();
                var train = new Train(m);
            }

            Console.WriteLine(Train.Count); //imprime el contador pero no es 10000000, cada vez que ejecutas el programa devuelve numeros distintos. Pienso que puede deberse a que en algún punto se resetea la memoria

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3); //Ambas expresiones son falsas ya que son todos objetos distintos, los tres ocupan espacios distintos en el heap de la memoria
        }

    }
}