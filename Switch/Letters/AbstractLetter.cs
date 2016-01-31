using System;
using Switch.Writter;

namespace Switch.Letters
{
    public abstract class AbstractLetter : ILetter
    {
        private Action action;
        private readonly IOutputWritter writter;
        private char c;

        protected AbstractLetter(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
        }

        protected void SetAction(Action act)
        {
            if (act != null)
            {
                this.action = act;
            }
        }

        protected void SetChar(char character)
        {
            this.c = character;
        }

        protected void Write(object input)
        {
            this.writter.WriteLine(input);
        }

        public Action GetAction()
        {
            return this.action;
        }

        public void ExecuteAction()
        {
            this.action.Invoke();
        }

        public bool IsForThisChar(char character)
        {
            return this.c == character;
        }

        public char Char { get { return this.c; } }
    }
}
