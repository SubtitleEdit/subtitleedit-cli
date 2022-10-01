using seconv.libse.Common;

namespace seconv.libse.Translate.Service
{
    public interface ITranslationStrategy
    {
        string GetName();
        string GetUrl();
        List<string> Translate(string sourceLanguage, string targetLanguage, List<Paragraph> sourceParagraphs);
        int GetMaxTextSize();
        int GetMaximumRequestArraySize();
    }
}
