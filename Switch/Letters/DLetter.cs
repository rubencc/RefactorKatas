using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Letters
{
    public class DLetter : AbstractLetter
    {
        public DLetter()
        {
            this.SetAction(() => Console.WriteLine("Es una b especular"));
        }
    }
}
