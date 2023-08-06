using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class DocumentSubjectRepos : IDocumentSubject
    {
        private readonly ApplicationDbContext _dbContext;

        public DocumentSubjectRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewDocumentSubject(DocumentSubjectClassify documentSubject)
        {
            var name = _dbContext.DocumentSubjectTable.FirstOrDefault(a =>
                a.DocumentSubject == documentSubject.DocumentSubject);
            if (name == null)
            {
                await _dbContext.DocumentSubjectTable.AddAsync(documentSubject);
                await _dbContext.SaveChangesAsync();
                return "The DocumentSubject Table has been successfully added to the database";
            }
            else
            {
                return "The DocumentSubject Table already exists in the database";
            }
        }

        public async Task<string> RemoveNewDocumentSubject(int id)
        {
            var obj = _dbContext.DocumentSubjectTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.DocumentSubjectTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Document Subject has been successfully removed from the database";
            }
            return "Can't Remove Document Subject from database";
        
        }

        public Task<string> UpdateNewDocumentSubject(DocumentSubjectClassify documentSubject)
        {
            throw new NotImplementedException();
        }
    }
}
