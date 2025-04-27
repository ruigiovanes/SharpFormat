using SharpFormat.Extensions;
using SharpFormat.Validators;

namespace SharpFormat.Formatters;

public static class CnpjFormatter
{
    public static string Format(string cnpj)
    {
        if (string.IsNullOrWhiteSpace(cnpj))
        {
            return string.Empty;
        }

        var digits = cnpj.OnlyNumbers();
        if (digits.Length != 14)
        {
            throw new ArgumentException("CNPJ must have exactly 14 digits.", nameof(cnpj));
        }

        return string.Format("{0}.{1}.{2}/{3}-{4}",
            digits.Substring(0, 2),
            digits.Substring(2, 3),
            digits.Substring(5, 3),
            digits.Substring(8, 4),
            digits.Substring(12, 2)
         );
    }
}
