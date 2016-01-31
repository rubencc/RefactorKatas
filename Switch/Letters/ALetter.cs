using Switch.Writter;

namespace Switch.Letters
{
    public class ALetter : AbstractLetter
    {
        public ALetter(IOutputWritter writter)
            :base(writter)
        {

            this.SetChar('a');
            this.SetAction(() => this.Write("Primera letra del alfabeto"));
        }
    }
}
