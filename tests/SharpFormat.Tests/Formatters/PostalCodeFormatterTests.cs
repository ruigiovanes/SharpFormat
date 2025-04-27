using Xunit;
using SharpFormat.Formatters;
using System;

namespace SharpFormat.Tests.Formatters
{
    public class PostalCodeFormatterTests
    {
        [Fact]
        public void Should_Format_ValidPostalCode()
        {
            var postalCode = "12345678";
            var formatted = PostalCodeFormatter.Format(postalCode);

            Assert.Equal("12345-678", formatted);
        }

        [Fact]
        public void Should_Format_PostalCode_WithSpecialCharacters()
        {
            var postalCode = "12345-678";
            var formatted = PostalCodeFormatter.Format(postalCode);

            Assert.Equal("12345-678", formatted);
        }

        [Fact]
        public void Should_ReturnEmpty_When_InputIsNullOrWhitespace()
        {
            Assert.Equal(string.Empty, PostalCodeFormatter.Format(null));
            Assert.Equal(string.Empty, PostalCodeFormatter.Format(""));
            Assert.Equal(string.Empty, PostalCodeFormatter.Format("   "));
        }

        [Fact]
        public void Should_ThrowArgumentException_When_PostalCodeHasInvalidLength()
        {
            var postalCode = "1234"; // muito curto

            var exception = Assert.Throws<ArgumentException>(() => PostalCodeFormatter.Format(postalCode));
            Assert.Equal("Postal code must have exactly 8 digits. (Parameter 'postalCode')", exception.Message);
        }
    }
}
