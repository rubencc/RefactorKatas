using FluentAssertions;
using NSubstitute;
using Switch.Letters;
using Switch.Writter;
using Xunit;

namespace Switch.Test
{
    [Trait("DLetter", "Unit test")]
    public class DLetterTests
    {
        private IOutputWritter writter;
        private DLetter letter;

        public DLetterTests()
        {
            this.writter = Substitute.For<IOutputWritter>();
            this.letter = new DLetter(this.writter);
        }

        ~DLetterTests()
        {
            this.writter = null;
            this.letter = null;
        }

        [Fact(DisplayName = "Ejecutar accion")]
        public void EjecutarAcction()
        {
            this.letter.ExecuteAction();

            this.writter.Received(1).WriteLine("Es una b especular");
        }

        [Fact(DisplayName = "Comprobar para es para la letra d")]
        public void IsForThisChar()
        {
            this.letter.IsForThisChar('d').Should().BeTrue();

        }
    }
}
