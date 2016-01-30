using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Switch.Letters;

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

            map.Add('a', new ALetter().GetAction());
            map.Add('b', new BLetter().GetAction());
            map.Add('c', new CLetter().GetAction());
            map.Add('d', new DLetter().GetAction());

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
    }
}
