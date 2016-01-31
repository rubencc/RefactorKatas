using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Collections;

namespace Switch.Loader
{
    public interface ILetterLoader
    {
        ILetterCollection Load();
    }
}
