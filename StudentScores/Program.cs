using System;
using System.Collections.Generic;

namespace StudentScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de los nombres de los estudiantes
            string[] studentsName = ["Jose", "Elizabeth", "Willy", "Juan", "Pedro", "Andres", "Santiago", "Nicole"];

            //Collecion ordenada de forma ascendente donde se almacenara el nombre y la calificacion de los estudiantes
            SortedList<string, int> sortedStudenScore = new SortedList<string, int>();

            int auxScore;

            foreach (var name in studentsName)
            {
                auxScore = 0;
                while (auxScore == 0)
                {
                    Console.WriteLine($"Proporcione la calificacion de {name}");
                    GetInteger(Console.ReadLine(), out auxScore);
                }
                sortedStudenScore.Add(name, auxScore);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============= STUDENTS SCORE =============");
            foreach (var item in sortedStudenScore){
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        //Metodo para captura via consola la calificacion del estudiante y convertirla de string a un valor entero
        private static void GetInteger(string? data, out int auxScore)
        {
            if (!int.TryParse(data, out auxScore))
            {
                Console.WriteLine("El valor que esta ingresando es incorrecto");
            }
        }
    }
}
