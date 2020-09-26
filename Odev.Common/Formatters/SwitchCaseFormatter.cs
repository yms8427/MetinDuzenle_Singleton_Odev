using System.Text;

namespace Odev.Common
{
    internal class SwitchCaseFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            var builder = new StringBuilder();
            foreach (var symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    if (char.IsUpper(symbol))
                    {
                        builder.Append(symbol.ToString().ToLower());
                    }
                    else
                    {
                        builder.Append(symbol.ToString().ToUpper());
                    }
                }
                else
                {
                    builder.Append(symbol);
                }
            }
            return builder.ToString();
        }
    }
}
