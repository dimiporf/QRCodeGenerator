using QRImplementation;

namespace QRCodeGenerator
{
    public class QREncoderTests
    {
        [Fact]
        public void TestNumericMode()
        {
            QREncoder encoder = new QREncoder();
            Assert.Equal(QREncodingMode.Numeric, encoder.DetermineEncodingMode("123456"));
        }

        [Fact]
        public void TestAlphanumericMode()
        {
            QREncoder encoder = new QREncoder();
            Assert.Equal(QREncodingMode.Alphanumeric, encoder.DetermineEncodingMode("ABC123$%"));
        }

        [Fact]
        public void TestByteMode()
        {
            QREncoder encoder = new QREncoder();
            Assert.Equal(QREncodingMode.Byte, encoder.DetermineEncodingMode("Hello"));
        }

        [Fact]
        public void TestKanjiMode()
        {
            QREncoder encoder = new QREncoder();
            Assert.Equal(QREncodingMode.Kanji, encoder.DetermineEncodingMode("漢字"));
        }

        [Fact]
        public void TestUnknownMode()
        {
            QREncoder encoder = new QREncoder();
            Assert.Equal(QREncodingMode.Unknown, encoder.DetermineEncodingMode("!@#"));
        }
    }
}