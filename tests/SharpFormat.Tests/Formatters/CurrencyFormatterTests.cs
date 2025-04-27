using Xunit;
using SharpFormat.Formatters;
using System;

namespace SharpFormat.Tests.Formatters
{
    public class CurrencyFormatterTests
    {
        [Fact]
        public void Should_Format_Brl_Currency()
        {
            decimal amount = 1999.99M;
            var formatted = CurrencyFormatter.Format(amount, "BRL");

            Assert.Equal("R$ 1.999,99", formatted);
        }

        [Fact]
        public void Should_Format_Usd_Currency()
        {
            decimal amount = 1999.99M;
            var formatted = CurrencyFormatter.Format(amount, "USD");

            Assert.Equal("$1,999.99", formatted);
        }

        [Fact]
        public void Should_Format_Eur_Currency()
        {
            decimal amount = 1999.99M;
            var formatted = CurrencyFormatter.Format(amount, "EUR");

            // Formatação alemã para Euro (€1.999,99)
            Assert.Contains("1.999,99", formatted);
        }

        [Fact]
        public void Should_ThrowArgumentException_When_CurrencyCodeIsNull()
        {
            decimal amount = 1000M;
            var exception = Assert.Throws<ArgumentException>(() => CurrencyFormatter.Format(amount, null));
            Assert.Equal("Currency code must not be null or empty. (Parameter 'currencyCode')", exception.Message);
        }

        [Fact]
        public void Should_ThrowNotSupportedException_When_CurrencyCodeIsUnsupported()
        {
            decimal amount = 1000M;
            var exception = Assert.Throws<NotSupportedException>(() => CurrencyFormatter.Format(amount, "ABC"));
            Assert.Equal("Currency code 'ABC' is not supported.", exception.Message);
        }
    }
}
