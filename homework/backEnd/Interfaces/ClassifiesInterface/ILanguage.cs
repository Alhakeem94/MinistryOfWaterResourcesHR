using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface ILanguage
    {
        public Task<string> Addlanguage(LanguageClassify language);
        public Task<string> Removelanguage(LanguageClassify language);
        public Task<string> Updatelanguage(LanguageClassify language);
    }
}
