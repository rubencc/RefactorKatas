using FluentAssertions;
using NSubstitute;
using Switch.Letters;
using Switch.Writter;
using Xunit;

namespace Switch.Test
{
    [Trait("BLetter", "Unit test")]
    public class BLetterTests
    {
        private IOutputWritter writter;
        private BLetter letter;

        public BLetterTests()
        {
            this.writter = Substitute.For<IOutputWritter>();
            this.letter = new BLetter(this.writter);
        }

        ~BLetterTests()
        {
            this.writter = null;
            this.letter = null;
        }

        [Fact(DisplayName = "Ejecutar accion")]
        public void EjecutarAcction()
        {
            this.letter.ExecuteAction();

            this.writter.Received(1).WriteLine("Sí, es una b");
        }

        [Fact(DisplayName = "Comprobar para es para la letra b")]
        public void IsForThisChar()
        {
            this.letter.IsForThisChar('b').Should().BeTrue();

        }
    }
}
