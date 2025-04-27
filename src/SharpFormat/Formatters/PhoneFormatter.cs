using SharpFormat.Extensions;

namespace SharpFormat.Formatters
{
    public static class PhoneFormatter
    {
        public static string Format(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return string.Empty;
            }

            var digits = phoneNumber.OnlyNumbers();

            return digits.Length switch
            {
                10 => $"({digits.Substring(0, 2)}) {digits.Substring(2, 4)}-{digits.Substring(6, 4)}", // Ex: (11) 2345-6789
                11 => $"({digits.Substring(0, 2)}) {digits.Substring(2, 5)}-{digits.Substring(7, 4)}", // Ex: (11) 91234-5678
                _ => throw new ArgumentException("Phone number must have 10 or 11 digits.", nameof(phoneNumber))
            };
        }
    }
}
