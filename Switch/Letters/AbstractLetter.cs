using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Letters
{
    public abstract class AbstractLetter : ILetter
    {
        private Action action;

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
