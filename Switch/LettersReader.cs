using System;
using System.Collections.Generic;
using System.Linq;
using Switch.Collections;
using Switch.Letters;
using Switch.Writter;

namespace Switch
{
    public class LettersReader
    {
        private readonly IOutputWritter writter;
        private readonly ILetterCollection letters;

        public LettersReader(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;

            this.letters = new LetterCollection();
            this.letters.Add(new ALetter(this.writter));
            this.letters.Add(new BLetter(this.writter));
            this.letters.Add(new CLetter(this.writter));
            this.letters.Add(new DLetter(this.writter));
        }

        public void ReadLetter(char c)
        {
            if (this.letters.Contains(c))
            {
                this.letters.Execute(c);
            }
            else
            {
                Action act = () => this.writter.WriteLine($"Ha escrito: {c}");
                act.Invoke();
            }
        }
    }
}
