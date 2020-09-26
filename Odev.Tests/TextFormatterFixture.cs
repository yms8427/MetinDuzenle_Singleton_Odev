using Microsoft.VisualStudio.TestTools.UnitTesting;
using Odev.Common;

namespace Odev.Tests
{
    [TestClass]
    public class TextFormatterFixture
    {
        private readonly string text = "ali Bak. ali ATA bak";
        public TextFormatterFixture()
        {
            Sut = new TextFormatter();
        }
        public TextFormatter Sut { get; set; }

        [TestMethod]
        public void AllLettersAreLoweeCase()
        {
            var output = Sut.Format(text, FormatterType.LowerCase);
            Assert.AreEqual("ali bak. ali ata bak", output);
        }

        [TestMethod]
        public void AllLettersAreUpperCase()
        {
            var output = Sut.Format(text, FormatterType.UpperCase);
            Assert.AreEqual("ALİ BAK. ALİ ATA BAK", output);
        }

        [TestMethod]
        public void SentenceFormat()
        {
            var output = Sut.Format(text, FormatterType.Sentence);
            Assert.AreEqual("Ali bak. Ali ata bak.", output);
        }

        [TestMethod]
        public void FirstWordIsUpper()
        {
            var output = Sut.Format(text, FormatterType.FirstWordUpper);
            Assert.AreEqual("Ali Bak. Ali Ata Bak", output);
        }

        [TestMethod]
        public void SwitchCaseLetters()
        {
            var output = Sut.Format(text, FormatterType.SwitchCase);
            Assert.AreEqual("ALİ bAK. ALİ ata BAK", output);
        }
    }
}
