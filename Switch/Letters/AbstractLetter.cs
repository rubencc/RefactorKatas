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

        public AbstractLetter(IOutputWritter writter)
        {
            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
        }


        protected void Write(object input)
        {
            this.writter.WriteLine(input);
        }

        protected void SetAction(Action act)
        {
            if (act != null)
            {
                this.action = act;
            }
        }

        public Action GetAction()
        {
            return this.action;
        }

        public void ExecuteAction()
        {
            this.action.Invoke();
        }
    }
}
