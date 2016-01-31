using FluentAssertions;
using NSubstitute;
using Switch.Letters;
using Switch.Writter;
using Xunit;

namespace Switch.Test
{
    [Trait("CLetter", "Unit test")]
    public class CLetterTests
    {
        private IOutputWritter writter;
        private CLetter letter;

        public CLetterTests()
        {
            this.writter = Substitute.For<IOutputWritter>();
            this.letter = new CLetter(this.writter);
        }

        ~CLetterTests()
        {
            this.writter = null;
            this.letter = null;
        }

        [Fact(DisplayName = "Ejecutar accion")]
        public void EjecutarAcction()
        {
            this.letter.ExecuteAction();

            this.writter.Received(1).WriteLine("Constante fisica que define la velocidad de la luz");
        }

        [Fact(DisplayName = "Comprobar para es para la letra c")]
        public void IsForThisChar()
        {
            this.letter.IsForThisChar('c').Should().BeTrue();

        }
    }
}
