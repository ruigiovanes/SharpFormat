using Xunit;
using SharpFormat.Formatters;
using System;

namespace SharpFormat.Tests.Formatters
{
    public class PhoneFormatterTests
    {
        [Fact]
        public void Should_Format_ValidFixedPhoneNumber()
        {
            var phone = "1123456789"; // 10 dígitos
            var formatted = PhoneFormatter.Format(phone);

            Assert.Equal("(11) 2345-6789", formatted);
        }

        [Fact]
        public void Should_Format_ValidMobilePhoneNumber()
        {
            var phone = "11912345678"; // 11 dígitos
            var formatted = PhoneFormatter.Format(phone);

            Assert.Equal("(11) 91234-5678", formatted);
        }

        [Fact]
        public void Should_Format_PhoneNumber_WithSpecialCharacters()
        {
            var phone = "(11) 91234-5678"; // já formatado
            var formatted = PhoneFormatter.Format(phone);

            Assert.Equal("(11) 91234-5678", formatted);
        }

        [Fact]
        public void Should_ReturnEmpty_When_InputIsNullOrWhitespace()
        {
            Assert.Equal(string.Empty, PhoneFormatter.Format(null));
            Assert.Equal(string.Empty, PhoneFormatter.Format(""));
            Assert.Equal(string.Empty, PhoneFormatter.Format("   "));
        }

        [Fact]
        public void Should_ThrowArgumentException_When_PhoneNumberHasInvalidLength()
        {
            var phone = "12345"; // inválido

            var exception = Assert.Throws<ArgumentException>(() => PhoneFormatter.Format(phone));
            Assert.Equal("Phone number must have 10 or 11 digits. (Parameter 'phoneNumber')", exception.Message);
        }
    }
}
