
# SharpFormat

**SharpFormat** is a simple and flexible C# library to format common data types such as CPF, CNPJ, phone numbers, postal codes, currency values, and more.

---

## 📦 Features

- Format CPF (Brazilian personal ID number)
- Format CNPJ (Brazilian company ID number)
- Format phone numbers (national and international)
- Format postal codes (CEP)
- Format currency values (BRL, USD, etc.)
- Format dates (Brazilian, ISO, US formats)
- Format license plates (old and Mercosul standards)
- Format percentages and big numbers
- Validation helpers (CPF, CNPJ, Email)
- And much more to come!

---

## 🚀 Installation

NuGet package coming soon!

For now, you can clone the repository and add the project reference manually:

```bash
git clone https://github.com/ruigiovanes/SharpFormat.git
```

---

## 🔥 Usage Example

```csharp
using SharpFormat.Formatters;

string cpf = "12345678909";
string formattedCpf = CpfFormatter.Format(cpf);
// Output: 123.456.789-09

string phone = "11987654321";
string formattedPhone = PhoneFormatter.Format(phone);
// Output: (11) 98765-4321

decimal price = 1999.99M;
string formattedCurrency = CurrencyFormatter.Format(price, "BRL");
// Output: R$ 1.999,99
```

---

## 🛤 Roadmap

- [x] Basic formatters (CPF, CNPJ, Phone, Postal Code)
- [x] Currency formatter with culture support
- [x] Date formatter
- [x] License plate formatter
- [ ] Validation helpers (CPF, CNPJ, Email)
- [ ] Publish as a NuGet package
- [ ] Unit tests for all formatters
- [ ] Documentation website

---

## 🤝 Contributing

Contributions are welcome!  
If you have any ideas, suggestions, or want to fix something, feel free to open an [issue](https://github.com/SeuUsuario/SharpFormat/issues) or submit a pull request.

Please make sure to update tests as appropriate.

---

## 📝 License

This project is licensed under the [MIT License](LICENSE).
