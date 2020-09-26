namespace Odev.Common
{
    internal class TextFormatterFactory
    {
        public ITextFormatter GetFormatter(FormatterType type)
        {
            switch (type)
            {
                case FormatterType.LowerCase:
                    return new LowerCaseFormatter();
                case FormatterType.UpperCase:
                    return new UpperCaseFormatter();
                case FormatterType.Sentence:
                    return new SentenceFormatter();
                case FormatterType.FirstWordUpper:
                    return new FirstWordUpperCaseFormatter();
                case FormatterType.SwitchCase:
                    return new SwitchCaseFormatter();
                default: throw new System.InvalidOperationException("formatter tanımlı değil");
            }
        }
    }
}
