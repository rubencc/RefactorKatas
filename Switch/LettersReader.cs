using System;
using System.Collections.Generic;
using Switch.Letters;
using Switch.Writter;

namespace Switch
{
    public class LettersReader
    {
        private readonly IOutputWritter writter;
        private readonly Dictionary<char, Action> map;

        public LettersReader(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
            this.map = new Dictionary<char, Action>();

            map.Add('a', () => new ALetter(this.writter).GetAction());
            map.Add('b', () => new BLetter(this.writter).GetAction());
            map.Add('c', () => new CLetter(this.writter).GetAction());
            map.Add('d', () => new DLetter(this.writter).GetAction());
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
