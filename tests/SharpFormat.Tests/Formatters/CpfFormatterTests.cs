using SharpFormat.Formatters;

namespace SharpFormat.Tests.Formatters
{
    public class CpfFormatterTests
    {
        [Fact]
        public void Should_Format_ValidCpf()
        {
            // Arrange
            var cpf = "12345678909";

            // Act
            var formatted = CpfFormatter.Format(cpf);

            // Assert
            Assert.Equal("123.456.789-09", formatted);
        }

        [Fact]
        public void Should_ReturnEmpty_When_InputIsNullOrWhitespace()
        {
            Assert.Equal(string.Empty, CpfFormatter.Format(null));
            Assert.Equal(string.Empty, CpfFormatter.Format(""));
            Assert.Equal(string.Empty, CpfFormatter.Format("   "));
        }

        [Fact]
        public void Should_ThrowArgumentException_When_InputHasInvalidLength()
        {
            // Arrange
            var input = "12345678"; // apenas 8 dígitos

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => CpfFormatter.Format(input));
            Assert.Equal("CPF must have exactly 11 digits. (Parameter 'cpf')", exception.Message);
        }

        [Fact]
        public void Should_Handle_InputWithSpecialCharacters()
        {
            var cpf = "123.456.789-09";
            var formatted = CpfFormatter.Format(cpf);
            Assert.Equal("123.456.789-09", formatted);
        }
    }
}
