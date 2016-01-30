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
        private readonly IOutputWritter writter;
        public BLetter(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
            this.SetChar('b');
            this.SetAction(() => this.writter.WriteLine("Sí, es una b"));
        }
    }
}
