using System;
using System.Collections.Generic;
using System.Linq;
using Switch.Letters;
using Switch.Writter;

namespace Switch
{
    public class LettersReader
    {
        private readonly IOutputWritter writter;
        private readonly List<ILetter> letters;

        public LettersReader(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;

            this.letters = new List<ILetter>() {new ALetter(this.writter), new BLetter(this.writter), new CLetter(this.writter), new DLetter(this.writter)};
        }

        public void ReadLetter(char c)
        {
            if (this.letters.Exists(item => item.IsForThisChar(c)))
            {
                ILetter letter = this.letters.Find(item => item.IsForThisChar(c));
                letter.ExecuteAction();
            }
            else
            {
                Action act = () => this.writter.WriteLine($"Ha escrito: {c}");
                act.Invoke();
            }
        }
    }
}
