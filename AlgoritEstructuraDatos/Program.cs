using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraciones de arreglos / arrays
            // #1
            Console.ForegroundColor = ConsoleColor.Red;
            int[] array1 = new int[3];
            array1[0] = 1;
            array1[1] = 2;
            Console.WriteLine($"array1[0]= {array1[0]} y array1[1] = {array1[1]} \n");

            // #2
            Console.ForegroundColor = ConsoleColor.Green;
            int[] array2 = { 2, 3, 5, 7 };
            string[] array3 = { "Lun", "Mar", "Mie", "Juv", "Vie", "Sab", "Dom" };

            Console.WriteLine($"array2[0]= {array2[0]}, array2[1]= {array2[1]}, array2[2]= {array2[2]}, " +
                $"array2[3]= {array2[3]}");

            Console.WriteLine($"array3[0]= {array3[0]}, array3[1]={array3[1]}, array3[2]={array3[2]}, " +
                $"array3[3]={array3[3]}, array3[4]={array3[4]}, array3[5]={array3[5]}, array3[6]={array3[6]} \n");

            // #3
            Console.ForegroundColor = ConsoleColor.Yellow;
            double[] array4;
            array4 = new double[] { 1.2, 2.2, 3.2 };
            Console.WriteLine($"array4[0]={array4[0]}, array4[1]= {array4[1]}, array4[2]= {array4[2]} \n");

            //Recorrer un arreglo
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            //Declarion de un arreglo dentro de otro arreglo
            Console.ForegroundColor = ConsoleColor.Magenta;
            int[][] arrayOfArrays = new int[2][];
            arrayOfArrays[0] = new int[] { 1 };
            arrayOfArrays[1] = new int[] { 2, 3, 4 };

            //Para itera arrelgos de este tipo se necesita hacer sentencias de foreach anidados
            foreach (int[] i in arrayOfArrays) //Este foreache recorre el primer arreglo
            {
                foreach (int j in i) // Este foreach recorre el segundo arreglo
                {
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine("\n");

            //La propiedad .length retorna la cantidad de elementos que tiene un arreglo
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"El array1 tiene {array1.Length} elementos");
            Console.WriteLine($"El array2 tiene {array2.Length} elementos");
            Console.WriteLine($"El array3 tiene {array3.Length} elementos");
            Console.WriteLine($"El array4 tiene {array4.Length} elementos");
            Console.WriteLine($"El arrayOfArrays tiene {arrayOfArrays.Length} elementos \n");

            //La propiedad .Rank retorna la cantidad de dimensiones que tiene un arrelgo
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"El array1 tiene {array1.Rank} dimensiones");
            Console.WriteLine($"El array2 tiene {array2.Rank} dimensiones");
            Console.WriteLine($"El array3 tiene {array3.Rank} dimensiones");
            Console.WriteLine($"El array4 tiene {array4.Rank} dimensiones");
            Console.WriteLine($"El arrayOfArrays tiene {arrayOfArrays.Length} dimensiones \n");

            //Arreglos de dos dimensiones
            //En este ejemplo se creara una matriz 2x2, donde la primer dimension hara referencia al grupo del estudiante
            // y la segunda al numero del estudiante y el valor que se asigne sera la calificacion de dicho estudiante
            Console.ForegroundColor = ConsoleColor.Cyan;
            int[,] studentScore = new int[2, 2];
            studentScore[0, 0] = 10; //el estudiante 0 del grupo 0 tiene una calificacion de 10
            studentScore[0, 1] = 9;
            studentScore[1, 0] = 7; //el estudiante 0 del grupo 1 tiene una calificacion de 7
            studentScore[1, 1] = 8;

            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una calificacion de: {studentScore[0, 0]}");
            Console.WriteLine($"El estudiante 2 del grupo 1 tiene una calificacion de: {studentScore[0, 1]}");
            Console.WriteLine($"El estudiante 1 del grupo 2 tiene una calificacion de: {studentScore[1, 0]}");
            Console.WriteLine($"El estudiante 2 del grupo 2 tiene una calificacion de: {studentScore[1, 1]}");

            Console.WriteLine($"El studentScore tiene {studentScore.Rank} dimensiones");

            Console.ReadKey();
        }
    }
}
