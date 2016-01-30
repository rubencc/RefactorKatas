using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una letra: ");
            var key = Console.ReadKey();
            Console.WriteLine(String.Empty);

            switch ((key.KeyChar))
            {
                case 'a':
                    Console.WriteLine("Primera letra del alfabeto");
                    break;
                case 'b':
                    Console.WriteLine("Sí, es una b");
                    break;
                case 'c':
                    Console.WriteLine("Constante fisica que define la velocidad de la luz");
                    break;
                case 'd':
                    Console.WriteLine("Es una b especular");
                    break;
                default:
                    Console.WriteLine("Ha escrito: {0} ", key.KeyChar);
                    break;
            }

            Console.WriteLine(String.Empty);
            Console.WriteLine("Fin");
            Console.ReadKey();
        }

        
    }
}
