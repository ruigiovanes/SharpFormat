using System.Globalization;

namespace SharpFormat.Formatters
{
    public static class CurrencyFormatter
    {
        public static string Format(decimal value, string currencyCode = "BRL")
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                throw new ArgumentException("Currency code must not be null or empty.", nameof(currencyCode));
            }

            var culture = GetCultureInfoByCurrencyCode(currencyCode);
            return string.Format(culture, "{0:C}", value);
        }

        private static CultureInfo GetCultureInfoByCurrencyCode(string currencyCode)
        {
            return currencyCode.ToUpper() switch
            {
                "BRL" => new CultureInfo("pt-BR"),
                "USD" => new CultureInfo("en-US"),
                "EUR" => new CultureInfo("de-DE"),
                "GBP" => new CultureInfo("en-GB"),
                _ => throw new NotSupportedException($"Currency code '{currencyCode}' is not supported.")
            };
        }
    }
}
