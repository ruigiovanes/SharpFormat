using System.Globalization;

namespace SharpFormat.Formatters
{
    public static class PercentFormatter
    {
        public static string Format(decimal value, int decimalPlaces = 2, string cultureCode = "pt-BR")
        {
            if (decimalPlaces < 0)
            {
                throw new ArgumentException("Decimal places must be zero or greater.", nameof(decimalPlaces));
            }

            if (string.IsNullOrWhiteSpace(cultureCode))
            {
                throw new ArgumentException("Culture code must not be null or empty.", nameof(cultureCode));
            }

            var culture = new CultureInfo(cultureCode);
            var format = "P" + decimalPlaces;

            return value.ToString(format, culture);
        }
    }
}
