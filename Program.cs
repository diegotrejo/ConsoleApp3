using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var temperaturas = new List<Double>();
            var temperaturas = new List<Double?> { 12321.345, 12321.35, 7846, 322, 99.56, null, null };

            temperaturas.Add(13312);
            temperaturas.Add(123.44);
            temperaturas.Add(12321.12321);
            temperaturas.Add(57567.131);

            temperaturas[0] = 90;
            temperaturas[1] = 80;
            temperaturas[2] = 70;

            var temp70  = temperaturas[2];

            temperaturas.Remove(80);
            temperaturas.Remove(temp70);
            temperaturas.Insert(1, 700);
            temperaturas.Insert(1, 800);
            temperaturas.Insert(1, 900);

            Double?[] copia = new double?[3];

            temperaturas.CopyTo(3, copia, 0, 3);
            var copia2 = temperaturas.GetRange(3, 5);

            Console.WriteLine("lista de temperaturas");
            Console.WriteLine("----------------------------");
            foreach (var item in temperaturas)
            { 
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            for(int i =0; i< temperaturas.Count; i++)
            {
                Console.WriteLine(temperaturas[i]);
            }



            // crear una lista de notas para 20 estudiantes en la materia POO
            // una vez la lista con los datos (al azar) se debe calcular:
            // el promedio de las notas
            // la nota máxima y mínima.

            var notas = new List<int> { 9, 7, 4, 10, 7, 6, 4, 5, 8, 9, 10, 10, 8, 9, 5, 7, 7, 7, 8, 5 };
            var avg = notas.Average();
            var min = notas.Min();  
            var max = notas.Max();

            Console.WriteLine("promedio = " + avg);
            Console.WriteLine("maximo  = " + max);
            Console.WriteLine("minimo = " + min);

            var datosDiferentes = new List<object>();

            datosDiferentes.Add(9019);
            datosDiferentes.Add("mensaje");
            datosDiferentes.Add(true);
            datosDiferentes.Add(982.9900);

            Console.WriteLine("lista de datos diferentes tipos");
            Console.WriteLine("----------------------------");
            foreach (var item in datosDiferentes)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
