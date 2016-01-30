using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Letters
{
    public interface ILetter
    {
        Action GetAction();
        void ExecuteAction();
    }
}
