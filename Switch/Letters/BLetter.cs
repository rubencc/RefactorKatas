using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Writter;

namespace Switch.Letters
{
    public class BLetter : AbstractLetter
    {
        public BLetter(IOutputWritter writter)
            : base(writter)
        {

            this.SetAction(() => this.Write("Sí, es una b"));
        }
    }
}
