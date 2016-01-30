using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            Dictionary<char, Action> map = new Dictionary<char, Action>();

            map.Add('a', () => Console.WriteLine("Primera letra del alfabeto"));
            map.Add('b', () => Console.WriteLine("Sí, es una b"));
            map.Add('c', () => Console.WriteLine("Constante fisica que define la velocidad de la luz"));
            map.Add('d', () => Console.WriteLine("Es una b especular"));

            if (map.ContainsKey(key.KeyChar))
            {
                map[key.KeyChar].Invoke();
            }
            else
            {
                Action act = () => Console.WriteLine("Ha escrito: {0} ", key.KeyChar);
                act.Invoke();
            }

            Console.WriteLine(String.Empty);
            Console.WriteLine("Fin");
            Console.ReadKey();
        }

        delegate void Letters(string s);
    }
}
