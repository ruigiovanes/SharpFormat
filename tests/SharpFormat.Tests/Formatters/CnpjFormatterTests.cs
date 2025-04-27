using SharpFormat.Formatters;

namespace SharpFormat.Tests.Formatters
{
    public class CnpjFormatterTests
    {
        [Fact]
        public void Should_Format_ValidCnpj()
        {
            // Arrange
            var cnpj = "12345678000195";

            // Act
            var formatted = CnpjFormatter.Format(cnpj);

            // Assert
            Assert.Equal("12.345.678/0001-95", formatted);
        }

        [Fact]
        public void Should_ReturnEmpty_When_InputIsNullOrWhitespace()
        {
            Assert.Equal(string.Empty, CnpjFormatter.Format(null));
            Assert.Equal(string.Empty, CnpjFormatter.Format(""));
            Assert.Equal(string.Empty, CnpjFormatter.Format("   "));
        }

        [Fact]
        public void Should_ThrowArgumentException_When_InputHasInvalidLength()
        {
            // Arrange
            var input = "12345678"; // apenas 8 dígitos

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => CnpjFormatter.Format(input));
            Assert.Equal("CNPJ must have exactly 14 digits. (Parameter 'cnpj')", exception.Message);
        }

        [Fact]
        public void Should_Handle_InputWithSpecialCharacters()
        {
            var cnpj = "12.345.678/0001-95";
            var formatted = CnpjFormatter.Format(cnpj);
            Assert.Equal("12.345.678/0001-95", formatted);
        }
    }
}
