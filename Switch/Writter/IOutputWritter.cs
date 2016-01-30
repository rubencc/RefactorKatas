using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Writter
{
    public interface IOutputWritter
    {
        void WriteLine(object input);
        void Write(Object input);
    }
}
