namespace Odev.Common
{
    internal class UpperCaseFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return text.ToUpper();
        }
    }
}
