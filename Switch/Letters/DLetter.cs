using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Writter;

namespace Switch.Letters
{
    public class DLetter : AbstractLetter
    {
        public DLetter(IOutputWritter writter)
            : base(writter)
        {
            this.SetAction(() => this.Write("Es una b especular"));
        }
    }
}
