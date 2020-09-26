namespace Odev.Common
{
    internal interface ITextFormatter
    {
        /// <summary>
        /// Verilen metini belirlenen biçime dönüştürür
        /// </summary>
        /// <param name="text">dönüştürülecek metin</param>
        /// <returns>biçimlendirilmiş metin</returns>
        string Format(string text);
    }
}
