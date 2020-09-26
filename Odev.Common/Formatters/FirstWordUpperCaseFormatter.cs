using System.Text;

namespace Odev.Common
{
    internal class FirstWordUpperCaseFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            var builder = new StringBuilder();
            var words = text.Split(' ');
            foreach (var word in words)
            {
                builder.Append(word.Substring(0,1).ToUpper());
                builder.Append(word.Substring(1).ToLower());
                builder.Append(" ");
            }
            return builder.ToString().Trim();
        }
    }
}
