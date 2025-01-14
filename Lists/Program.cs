using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== LISTS o LISTAS ===== \n");

            //Creando una lista y creando varias instancias de la misma
            Console.ForegroundColor = ConsoleColor.Green;
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);
            ShowItemsList(list1);

            //CONTAINS y REMOVE
            Console.ForegroundColor= ConsoleColor.Red;
            if (list1.Contains(5))
            {
                list1.Remove(5);
                Console.WriteLine("\nEl #5 fue removido de la lista");
            }
            ShowItemsList(list1 );

            //Aqui se tendra una condicion para verificar si el numero 5 no se encuentra en la lista  y sino lo esta se insertara
            Console.ForegroundColor = ConsoleColor.Green;
            if (!list1.Contains(5))
            {
                list1.Insert(4, 5); //El 1er parametro es el indice y 2do parametro el elemento a insertar
                Console.WriteLine("\nEl #5 fue insertado en el indice 4");
            }
            ShowItemsList(list1);

            //Creando e instanciando una lista en  una sola linea
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nCreando e instanciando una lista en  una sola linea");
            List<int> list2 = new List<int>{10, 20, 30, 40};
            ShowItemsList (list2);

            //InsertRange(), inserta una lista en una posicion proporcionada de otra lista
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nInsertando una lista dentro de otra con .InsertRange(index, listN)");
            list2.InsertRange(0, list1 ); //En la lista 2 se estara insertando en la posicion 0 a la lista 1
            ShowItemsList(list2);


            Console.ReadKey();
        }

        //Metodo para mostrar los elementos de una lista
        private static void ShowItemsList(List<int> list1)
        {
            // se usa la el tipo de variable var, para que la variable que venga sea mas generica, asi sea un int, string, double, etc
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
