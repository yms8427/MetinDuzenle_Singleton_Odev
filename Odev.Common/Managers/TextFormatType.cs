namespace Odev.Common
{
    public class TextFormatType
    {
        public TextFormatType(string displayName, FormatterType type)
        {
            DisplayName = displayName;
            Type = type;
        }

        public string DisplayName { get; }
        public FormatterType Type { get; }
    }
}
