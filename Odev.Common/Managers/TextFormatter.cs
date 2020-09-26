namespace Odev.Common
{
    public class TextFormatter
    {
        public string Format(string text, FormatterType type)
        {
            var factory = new TextFormatterFactory();
            var formatter = factory.GetFormatter(type);
            return formatter.Format(text);
        }
    }
}
