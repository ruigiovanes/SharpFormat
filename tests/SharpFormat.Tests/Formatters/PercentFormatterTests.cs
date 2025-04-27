using Xunit;
using SharpFormat.Formatters;
using System;

namespace SharpFormat.Tests.Formatters
{
    public class PercentFormatterTests
    {
        [Fact]
        public void Should_Format_Percent_With_DefaultValues()
        {
            decimal value = 0.1234M;
            var formatted = PercentFormatter.Format(value);

            Assert.Equal("12,34%", formatted);
        }

        [Fact]
        public void Should_Format_Percent_With_CustomDecimalPlaces()
        {
            decimal value = 0.123456M;
            var formatted = PercentFormatter.Format(value, 3);

            Assert.Equal("12,346%", formatted);
        }

        [Fact]
        public void Should_Format_Percent_With_EnglishCulture()
        {
            decimal value = 0.25M;
            var formatted = PercentFormatter.Format(value, 1, "en-US");

            Assert.Equal("25.0%", formatted);
        }

        [Fact]
        public void Should_ThrowArgumentException_When_DecimalPlacesIsNegative()
        {
            decimal value = 0.5M;

            var exception = Assert.Throws<ArgumentException>(() => PercentFormatter.Format(value, -1));
            Assert.Equal("Decimal places must be zero or greater. (Parameter 'decimalPlaces')", exception.Message);
        }

        [Fact]
        public void Should_ThrowArgumentException_When_CultureIsNull()
        {
            decimal value = 0.5M;

            var exception = Assert.Throws<ArgumentException>(() => PercentFormatter.Format(value, 2, null));
            Assert.Equal("Culture code must not be null or empty. (Parameter 'cultureCode')", exception.Message);
        }
    }
}
