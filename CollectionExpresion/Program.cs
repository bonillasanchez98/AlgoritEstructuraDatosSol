using System;

namespace CollectionExpresion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Las expresiones (dos puntos ..) de colecciones nos ayudan a poder acceder directamente al contenido de una coleccion
            string[] vowels = ["a", "e", "i", "o", "u"];
            string[] someConsonants = ["b", "c", "d", "f", "...."];

            //En este caso se inicializo el arreglo alphabet con contenido de los arreglos vowels y someConsonants y agregar algun otro valor
            string[] alphabet = [..vowels, ..someConsonants, "....", "y", "z"]; 

            foreach (var letter in alphabet)
            {
                Console.WriteLine(letter);
            }

            Console.ReadKey();
        }
    }
}
