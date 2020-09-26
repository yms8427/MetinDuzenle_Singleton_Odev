using System.Text;

namespace Odev.Common
{
    internal class SentenceFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            var builder = new StringBuilder();
            var sentences = text.Split('.');
            foreach (var sentence in sentences)
            {
                if (string.IsNullOrEmpty(sentence))
                {
                    continue;
                }
                builder.Append(sentence.TrimStart().Substring(0, 1).ToUpper());
                builder.Append(sentence.TrimStart().Substring(1).ToLower());
                builder.Append(". ");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
