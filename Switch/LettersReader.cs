using System;
using System.Collections.Generic;
using Switch.Writter;

namespace Switch
{
    public class LettersReader
    {
        private readonly IOutputWritter writter;
        private Dictionary<char, Action> map;

        public LettersReader(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
            this.map = new Dictionary<char, Action>();

            map.Add('a', () => this.writter.WriteLine("Primera letra del alfabeto"));
            map.Add('b', () => this.writter.WriteLine("Sí, es una b"));
            map.Add('c', () => this.writter.WriteLine("Constante fisica que define la velocidad de la luz"));
            map.Add('d', () => this.writter.WriteLine("Es una b especular"));
        }

        public void ReadLetter(char c)
        {
            if (map.ContainsKey(c))
            {
                map[c].Invoke();
            }
            else
            {
                Action act = () => this.writter.WriteLine($"Ha escrito: {c}");
                act.Invoke();
            }
        }
    }
}
