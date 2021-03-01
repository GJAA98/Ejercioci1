using System;

namespace Pracita_separar_nombre_con_espacios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte un nombre:");
            string nombre = Console.ReadLine();            
            string valor = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                char letra = nombre[i];
                valor +=letra+ " ";
            }
            Console.WriteLine(valor);
        }
    }
}
