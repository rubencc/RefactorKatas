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
        private readonly IOutputWritter writter;
        public ALetter(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
            this.SetChar('a');
            this.SetAction(() => this.writter.WriteLine("Primera letra del alfabeto"));
        }
    }
}
