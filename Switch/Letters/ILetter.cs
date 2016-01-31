using System;

namespace Switch.Letters
{
    public interface ILetter
    {
        Action GetAction();
        void ExecuteAction();
        bool IsForThisChar(char character);
        char Char { get; }
    }
}
