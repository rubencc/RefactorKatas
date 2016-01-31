using Switch.Writter;

namespace Switch.Letters
{
    public class CLetter : AbstractLetter
    {
        public CLetter(IOutputWritter writter)
            : base(writter)
        {

            this.SetChar('c');
            this.SetAction(() => this.Write("Constante fisica que define la velocidad de la luz"));
        }
    }
}
