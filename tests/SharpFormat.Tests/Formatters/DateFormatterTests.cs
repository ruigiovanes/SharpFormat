using Xunit;
using SharpFormat.Formatters;
using System;

namespace SharpFormat.Tests.Formatters
{
    public class DateFormatterTests
    {
        [Fact]
        public void Should_Format_Date_With_DefaultFormatAndCulture()
        {
            // Arrange
            var date = new DateTime(2025, 4, 27);

            // Act
            var formatted = DateFormatter.Format(date);

            // Assert
            Assert.Equal("27/04/2025", formatted);
        }

        [Fact]
        public void Should_Format_Date_With_CustomFormat()
        {
            var date = new DateTime(2025, 4, 27);
            var formatted = DateFormatter.Format(date, "yyyy-MM-dd");

            Assert.Equal("2025-04-27", formatted);
        }

        [Fact]
        public void Should_Format_Date_With_CustomCulture()
        {
            var date = new DateTime(2025, 4, 27);
            var formatted = DateFormatter.Format(date, "D", "en-US");

            Assert.Equal("Sunday, April 27, 2025", formatted);
        }

        [Fact]
        public void Should_ThrowArgumentException_When_FormatIsNull()
        {
            var date = DateTime.Now;

            var exception = Assert.Throws<ArgumentException>(() => DateFormatter.Format(date, null));
            Assert.Equal("Format must not be null or empty. (Parameter 'format')", exception.Message);
        }

        [Fact]
        public void Should_ThrowArgumentException_When_CultureIsNull()
        {
            var date = DateTime.Now;

            var exception = Assert.Throws<ArgumentException>(() => DateFormatter.Format(date, "dd/MM/yyyy", null));
            Assert.Equal("Culture code must not be null or empty. (Parameter 'cultureCode')", exception.Message);
        }
    }
}
