using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Writter;

namespace Switch.Letters
{
    public class CLetter : AbstractLetter
    {
        private readonly IOutputWritter writter;
        public CLetter(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
            this.SetChar('c');
            this.SetAction(() => this.writter.WriteLine("Constante fisica que define la velocidad de la luz"));
        }
    }
}
