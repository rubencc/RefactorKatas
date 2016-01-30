using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Letters
{
    public class ALetter : AbstractLetter
    {
        public ALetter()
        {
            this.SetAction(() => Console.WriteLine("Primera letra del alfabeto"));
        }
    }
}
