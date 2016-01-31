using NSubstitute;
using Switch.Collections;
using Switch.Loader;
using Switch.Writter;
using Xunit;

namespace Switch.Test
{
    [Trait("LettersReader","Unit test")]
    public class LettersReaderTests
    {
        private LettersReader reader;
        private IOutputWritter writter;
        private ILetterLoader loader;
        private ILetterCollection collection;

        public LettersReaderTests()
        {
            this.collection = Substitute.For<ILetterCollection>();
            this.loader = Substitute.For<ILetterLoader>();
            this.loader.Load().Returns(this.collection);
            this.writter = Substitute.For<IOutputWritter>();
            this.reader = new LettersReader(this.writter, this.loader);
        }

        ~LettersReaderTests()
        {
            this.reader = null;
        }

        [Fact(DisplayName = "Leer una letra contenida en la coleccion")]
        public void LeerA()
        {
            char c = 'a';

            this.collection.Contains(c).Returns(true);

            this.reader.ReadLetter(c);

            this.collection.Received(1).Execute(c);
        }

        [Fact(DisplayName = "Leer una letra no contenida en la coleccion")]
        public void LeerX()
        {
            char c = 'x';

            this.reader.ReadLetter(c);

            this.writter.Received(1).WriteLine("Ha escrito: x");
        }
    }
}
