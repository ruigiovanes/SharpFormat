using SharpFormat.Extensions;

namespace SharpFormat.Formatters
{
    public static class PostalCodeFormatter
    {
        public static string Format(string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return string.Empty;
            }

            var digits = postalCode.OnlyNumbers();
            if (digits.Length != 8)
            {
                throw new ArgumentException("Postal code must have exactly 8 digits.", nameof(postalCode));
            }

            return $"{digits.Substring(0, 5)}-{digits.Substring(5, 3)}";
        }
    }
}
