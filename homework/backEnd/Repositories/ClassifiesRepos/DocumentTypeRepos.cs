using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class DocumentTypeRepos : IDocumentType
    {
        private readonly ApplicationDbContext _dbContext;

        public DocumentTypeRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddDocumentType(DocumentTypeClassify documentType)
        {
            var name = _dbContext.DocumentTypeTable.FirstOrDefault(a => a.DocumentType == documentType.DocumentType);
            if (name == null)
            {
                await _dbContext.DocumentTypeTable.AddAsync(documentType);
                await _dbContext.SaveChangesAsync();
                return "The DocumentType Table has been successfully added to the database";
            }
            else
            {
                return "The DocumentType Table already exists in the database";
            }
        }

        public async Task<string> RemoveDocumentType(int id)
        {
            var obj = _dbContext.DocumentTypeTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.DocumentTypeTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Document Type has been successfully removed from the database";
            }
            return "Can't Remove Document Type from database";
        
        }

        public Task<string> UpdateDocumentType(DocumentTypeClassify documentType)
        {
            throw new NotImplementedException();
        }
    }
}
