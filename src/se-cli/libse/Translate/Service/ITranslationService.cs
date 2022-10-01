namespace seconv.libse.Translate.Service
{
    public interface ITranslationService : ITranslationStrategy
    {
        List<TranslationPair> GetSupportedSourceLanguages();

        List<TranslationPair> GetSupportedTargetLanguages();
    }
}
