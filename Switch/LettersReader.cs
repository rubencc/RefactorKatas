using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Writter;

namespace Switch
{
    public class LettersReader
    {
        private readonly IOutputWritter writter;

        public LettersReader(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
        }

        public void ReadLetter(char c)
        {
            switch (c)
            {
                case 'a':
                    this.writter.WriteLine("Primera letra del alfabeto");
                    break;
                case 'b':
                    this.writter.WriteLine("Sí, es una b");
                    break;
                case 'c':
                    this.writter.WriteLine("Constante fisica que define la velocidad de la luz");
                    break;
                case 'd':
                    this.writter.WriteLine("Es una b especular");
                    break;
                default:
                    this.writter.WriteLine($"Ha escrito: {c}");
                    break;
            }
        }
    }
}
