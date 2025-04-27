namespace SharpFormat.Extensions
{
    public static class StringExtensions
    {
        public static string OnlyNumbers(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return new string(input.Where(char.IsDigit).ToArray());
        }
    }
}
