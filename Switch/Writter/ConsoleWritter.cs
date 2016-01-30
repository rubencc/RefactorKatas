using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Writter
{
    public class ConsoleWritter : IOutputWritter
    {
        public void WriteLine(object input)
        {
            Console.WriteLine(input.ToString());
        }

        public void Write(object input)
        {
            Console.Write(input.ToString());
        }
    }
}
