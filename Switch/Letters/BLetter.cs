using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Letters
{
    public class BLetter : AbstractLetter
    {
        public BLetter()
        {
            this.SetAction(() => Console.WriteLine("Sí, es una b"));
        }
    }
}
