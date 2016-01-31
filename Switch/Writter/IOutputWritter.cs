using System;

namespace Switch.Writter
{
    public interface IOutputWritter
    {
        void WriteLine(object input);
        void Write(Object input);
    }
}
