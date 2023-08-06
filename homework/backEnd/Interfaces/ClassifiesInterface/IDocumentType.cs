using homework.backEnd.Repositories.ClassifiesRepos;
using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IDocumentType
    {
        public Task<string> AddDocumentType(DocumentTypeClassify documentType);
        public Task<string> RemoveDocumentType(int id);
        public Task<string> UpdateDocumentType(DocumentTypeClassify documentType);
    }
}

