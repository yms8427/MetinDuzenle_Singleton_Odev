namespace Odev.Common
{
    internal class LowerCaseFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return text.ToLower();
        }
    }
}
