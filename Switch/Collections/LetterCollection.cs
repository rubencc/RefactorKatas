using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Letters;

namespace Switch.Collections
{
    public class LetterCollection : ILetterCollection
    {
        private readonly List<ILetter> letters;

        public LetterCollection()
        {
            this.letters = new List<ILetter>();
        }

        public LetterCollection(List<ILetter> list)
        {
            this.letters = list;
        }

        public void Add(ILetter letter)
        {
            if(letter != null)
                this.letters.Add(letter);
        }

        public void Delete(char c)
        {
            if (this.letters.Exists(item => item.IsForThisChar(c)))
            {
                ILetter letter = this.letters.Find(item => item.IsForThisChar(c));
                this.letters.Remove(letter);
            }
        }

        public bool Contains(char c)
        {
            return this.letters.Exists(item => item.IsForThisChar(c));
        }

        public ILetter GetForChar(char c)
        {
            if (this.letters.Exists(item => item.IsForThisChar(c)))
            {
                return this.letters.Find(item => item.IsForThisChar(c));
            }

            throw new KeyNotFoundException();
        }

        public void Execute(char c)
        {
            if (this.letters.Exists(item => item.IsForThisChar(c)))
            {
                ILetter letter = this.letters.Find(item => item.IsForThisChar(c));
                letter.ExecuteAction();
            }
        }
    }
}
