﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Switch.Letters;
using Switch.Loader;
using Switch.Writter;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterLoader loader = new LetterLoader(ConsoleWritter.Instance);
            LettersReader reader = new LettersReader(ConsoleWritter.Instance, loader);

            Console.WriteLine("Escribe una letra: ");
            var key = Console.ReadKey();
            Console.WriteLine(String.Empty);
           
            reader.ReadLetter(key.KeyChar);          

            Console.WriteLine(String.Empty);
            Console.WriteLine("Fin");
            Console.ReadKey();
        }

    }
}
