using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Switch.Writter;
using Xunit;

namespace Switch.Test
{
    [Trait("LettersReader","Unit test")]
    public class LettersReaderTests
    {
        private LettersReader reader;
        private IOutputWritter writter;

        public LettersReaderTests()
        {
            this.writter = Substitute.For<IOutputWritter>();
            this.reader = new LettersReader(this.writter);
        }

        ~LettersReaderTests()
        {
            this.reader = null;
        }

        [Fact(DisplayName = "Leer la letra A")]
        public void LeerA()
        {
            char c = 'a';

            this.reader.ReadLetter(c);

            this.writter.Received(1).WriteLine("Primera letra del alfabeto");
        }

        [Fact(DisplayName = "Leer la letra B")]
        public void LeerB()
        {
            char c = 'b';

            this.reader.ReadLetter(c);

            this.writter.Received(1).WriteLine("Sí, es una b");
        }

        [Fact(DisplayName = "Leer la letra C")]
        public void LeerC()
        {
            char c = 'c';

            this.reader.ReadLetter(c);

            this.writter.Received(1).WriteLine("Constante fisica que define la velocidad de la luz");
        }

        [Fact(DisplayName = "Leer la letra D")]
        public void LeerD()
        {
            char c = 'd';

            this.reader.ReadLetter(c);

            this.writter.Received(1).WriteLine("Es una b especular");
        }

        [Fact(DisplayName = "Leer la letra X")]
        public void LeerX()
        {
            char c = 'x';

            this.reader.ReadLetter(c);

            this.writter.Received(1).WriteLine("Ha escrito: x");
        }
    }
}
