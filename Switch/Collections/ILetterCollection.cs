using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Letters;

namespace Switch.Collections
{
    public interface ILetterCollection
    {
        void Add(ILetter letter);
        void Delete(char c);
        bool Contains(char c);
        ILetter GetForChar(char c);
        void Execute(char c);
    }
}
