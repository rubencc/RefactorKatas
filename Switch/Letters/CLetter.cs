using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Letters
{
    public class CLetter : AbstractLetter
    {
        public CLetter()
        {
            this.SetAction(() => Console.WriteLine("Constante fisica que define la velocidad de la luz"));
        }
    }
}
