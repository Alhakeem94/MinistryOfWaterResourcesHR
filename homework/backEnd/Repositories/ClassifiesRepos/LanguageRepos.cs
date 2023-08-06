using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class LanguageRepos : ILanguage
    {
        private readonly ApplicationDbContext _dbContext;

        public LanguageRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Addlanguage(LanguageClassify language)
        {
            var name = _dbContext.LanguageTable.FirstOrDefault(a => a.Language == language.Language);
            if (name == null)
            {
                await _dbContext.LanguageTable.AddAsync(language);
                await _dbContext.SaveChangesAsync();
                return "The Language Table has been successfully added to the database";
            }
            return "The Language Table already exists in the database";
        }

        public Task<string> Removelanguage(LanguageClassify language)
        {
            throw new NotImplementedException();
        }

        public Task<string> Updatelanguage(LanguageClassify language)
        {
            throw new NotImplementedException();
        }
    }
}
