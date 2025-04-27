using System.Globalization;

namespace SharpFormat.Formatters
{
    public static class DateFormatter
    {
        public static string Format(DateTime date, string format = "dd/MM/yyyy", string cultureCode = "pt-BR")
        {
            if (string.IsNullOrWhiteSpace(format))
            {
                throw new ArgumentException("Format must not be null or empty.", nameof(format));
            }

            if (string.IsNullOrWhiteSpace(cultureCode))
            {
                throw new ArgumentException("Culture code must not be null or empty.", nameof(cultureCode));
            }

            var culture = new CultureInfo(cultureCode);

            return date.ToString(format, culture);
        }
    }
}
