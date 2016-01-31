using System;
using Switch.Collections;
using Switch.Loader;
using Switch.Writter;

namespace Switch
{
    public class LettersReader
    {
        private readonly IOutputWritter writter;
        private readonly ILetterCollection letters;
        private readonly ILetterLoader loader;

        public LettersReader(IOutputWritter writter, ILetterLoader loader)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            if (loader == null)
            {
                throw new ArgumentNullException(nameof(loader));
            }

            this.writter = writter;
            this.loader = loader;

            this.letters = this.loader.Load();
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
