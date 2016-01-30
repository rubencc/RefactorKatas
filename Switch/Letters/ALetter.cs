using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Writter;

namespace Switch.Letters
{
    public class ALetter : AbstractLetter
    {

        public ALetter(IOutputWritter writter)
            :base(writter)
        {          
            this.SetAction(() => this.Write("Primera letra del alfabeto"));
        }
    }
}
