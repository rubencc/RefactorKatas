using Switch.Writter;

namespace Switch.Letters
{
    public class DLetter : AbstractLetter
    {
        public DLetter(IOutputWritter writter)
            : base(writter)
        {

            this.SetChar('d');
            this.SetAction(() => this.Write("Es una b especular"));
        }
    }
}
