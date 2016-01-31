using FluentAssertions;
using NSubstitute;
using Switch.Letters;
using Switch.Writter;
using Xunit;

namespace Switch.Test
{
    [Trait("ALetter", "Unit test")]
    public class ALetterTests
    {
        private IOutputWritter writter;
        private ALetter letter;

        public ALetterTests()
        {
            this.writter = Substitute.For<IOutputWritter>();
            this.letter = new ALetter(this.writter);
        }

        ~ALetterTests()
        {
            this.writter = null;
            this.letter = null;
        }

        [Fact(DisplayName = "Ejecutar accion")]
        public void EjecutarAcction()
        {
            this.letter.ExecuteAction();

            this.writter.Received(1).WriteLine("Primera letra del alfabeto");
        }

        [Fact(DisplayName = "Comprobar para es para la letra a")]
        public void IsForThisChar()
        {
            this.letter.IsForThisChar('a').Should().BeTrue();

        }
    }
}
