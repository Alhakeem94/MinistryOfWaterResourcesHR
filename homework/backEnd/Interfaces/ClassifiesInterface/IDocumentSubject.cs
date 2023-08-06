using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IDocumentSubject
    {
        
        public Task<string> AddNewDocumentSubject(DocumentSubjectClassify documentSubject);
        public Task<string> RemoveNewDocumentSubject( int id);

        public Task<string> UpdateNewDocumentSubject(DocumentSubjectClassify documentSubject);
    }
}
