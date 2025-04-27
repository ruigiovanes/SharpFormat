using SharpFormat.Extensions;
using SharpFormat.Validators;

namespace SharpFormat.Formatters;

public static class CpfFormatter
{
    public static string Format(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            return string.Empty;
        }

        var digits = cpf.OnlyNumbers();
        if (digits.Length != 11)
        {
            throw new ArgumentException("CPF must have exactly 11 digits.", nameof(cpf));
        }

        return string.Format("{0}.{1}.{2}-{3}",
            digits.Substring(0, 3),
            digits.Substring(3, 3),
            digits.Substring(6, 3),
            digits.Substring(9, 2)
        );
    }
}
