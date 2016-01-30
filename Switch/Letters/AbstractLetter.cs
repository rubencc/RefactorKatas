using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch.Writter;

namespace Switch.Letters
{
    public abstract class AbstractLetter : ILetter
    {
        private Action action;
        private readonly IOutputWritter writter;
        private char c;

        protected void SetAction(Action act)
        {
            if (act != null)
            {
                this.action = act;
            }
        }

        protected void SetChar(char c)
        {
            this.c = c;
        }

        public Action GetAction()
        {
            return this.action;
        }

        public void ExecuteAction()
        {
            this.action.Invoke();
        }

        public bool IsForThisChar(char c)
        {
            return this.c == c;
        }
    }
}
