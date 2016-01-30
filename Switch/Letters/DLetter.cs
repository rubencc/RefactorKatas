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
        private readonly IOutputWritter writter;
        public DLetter(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
            this.SetChar('d');
            this.SetAction(() => this.writter.WriteLine("Es una b especular"));
        }
    }
}
