using Switch.Writter;

namespace Switch.Letters
{
    public class BLetter : AbstractLetter
    {
        public BLetter(IOutputWritter writter)
            : base(writter)
        {

            this.SetChar('b');
            this.SetAction(() => this.Write("Sí, es una b"));
        }
    }
}
