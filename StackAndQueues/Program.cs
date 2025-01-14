using System;
using System.Collections;

namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====== STACK o PILAS ======\n");

            //STACK o PILAS
            string word; //Esta variable su usara para guardar la pila antes de que se modifique
            int counter; // Esta sera la variable usada en la iteracion de la pila
            Stack greetingStack = new Stack(); //esta es la pila

            //Usando PUSH(Para agregar elementos en la pila) y POP(Para eliminar el ultimo elemento ingresado de la pila) 
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack.Push("Hola");
            greetingStack.Push("Buenos");
            greetingStack.Push("Dias!");

            counter = greetingStack.Count; //esta propieda retorna el numero de elementos que tiene la pila
            Console.WriteLine($"Elementos de la pila antes del POP: {counter} \n");

            //Para recorre una pila se puede usar la estructura de control for tradicional o clasica
            for (int i = 0; i < counter; i++)
            {
                //este for estara iterando hasta que i (c/u de los elementos de la pila) sean menor que counter,
                //o sea la cantidad de numeros que haya (en este caso 3)
                word = greetingStack.Pop() as string;
                Console.WriteLine($"Pop: { word}");
            }
            Console.WriteLine($"\nElementos de la pila despues del POP: {greetingStack.Count} \n");


            //Uso de PEEK, esta propieda muestra el elemento que sigue de la pila (no hace ninguna modificacion en la pila)
            Console.ForegroundColor = ConsoleColor.Blue;
            greetingStack.Push("Hello");
            greetingStack.Push("Good");
            greetingStack.Push("Morning!");

            counter = greetingStack.Count;
            for (int i = 0; i < counter; i++)
            {
                word = greetingStack.Peek() as string;
                Console.WriteLine($"PEEK: {word}");
                
                word = greetingStack.Pop() as string;
                Console.WriteLine($"POP: {word} \n");
            }

            //Uso CONTAINS(Para verificar si la pila contiene algun elemento enviado por parametro) y CLEAR(Limpiar o vacia la pila)
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetingStack.Push("Hello");
            greetingStack.Push("Good");
            greetingStack.Push("Morning!");

            Console.WriteLine($"La cantidad de elementos de la pila antes del CLEAR: {greetingStack.Count}");

            if(greetingStack.Contains("Hello")) //Si la pila contiene la palabra "Hello" se limpara
            {
                greetingStack.Clear();
            }
            Console.WriteLine($"La cantidad de elementos de la pila despues del CLEAR: {greetingStack.Count} \n");

            //COLAS o QUEUES
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====== COLAS o QUEUES ======\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Queue greetingQueue = new Queue();
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("Buenos");
            greetingQueue.Enqueue("Dias!");


            counter = greetingQueue.Count;
            Console.WriteLine($"La cantidad de elementos de la cola antes del DEQUEUE: {greetingQueue.Count} \n");
            for (int i = 0; i < counter; i++)
            {
                word = greetingQueue.Peek() as string;
                Console.WriteLine($"PEEK: {word}");

                word = greetingQueue.Dequeue() as string;
                Console.WriteLine($"DEQUEUE: {word} \n");
            }
            Console.WriteLine($"La cantidad de elementos de la cola despues del DEQUEUE: {greetingQueue.Count} \n");

            //Uso de CONTAINS y CLEAR colas
            Console.ForegroundColor = ConsoleColor.White;
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("Buenos");
            greetingQueue.Enqueue("Dias!");

            Console.WriteLine($"La cantidad de elementos de la cola antes del CLEAR: {greetingQueue.Count}");

            if (greetingQueue.Contains("Buenos")) //Si la cola contiene la palabra "Hello" se limpara
            {
                greetingQueue.Clear();
            }
            Console.WriteLine($"La cantidad de elementos de la cola despues del CLEAR: {greetingQueue.Count} \n");


            Console.ReadKey();
        }
    }
}
