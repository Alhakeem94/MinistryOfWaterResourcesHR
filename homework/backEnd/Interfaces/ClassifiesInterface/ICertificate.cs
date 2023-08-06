



using homework.backEnd.Repositories.ClassifiesRepos;
using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface ICertificate
    {
        public Task<string> AddNewCertificate( CertificateClassify certificateClassify);
        public Task<string> RemoveCertificate( int id);
        public Task<string> UpdateCertificate(CertificateClassify certificateClassify);
    }
}
