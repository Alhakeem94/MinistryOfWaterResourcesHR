using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class CertificateClassifyRepos : ICertificate
    {
        private readonly ApplicationDbContext _dbContext;

        public CertificateClassifyRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<string> AddNewCertificate(CertificateClassify certificateClassify)
        {
            var name =  _dbContext.CertificateTabel.FirstOrDefault(a =>
                a.Certification == certificateClassify.Certification);
            if (name == null)
            {
                await _dbContext.CertificateTabel.AddAsync(certificateClassify);
                await _dbContext.SaveChangesAsync();
                return "The Certificate has been successfully added to the database";
            }
            else
            {
                return "The Certificate Stand Table already exists in the database";
            }
        }

        public async Task<string> RemoveCertificate(int id)
        {
            var obj = _dbContext.CertificateTabel.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.CertificateTabel.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Certificate has been successfully removed from the database";
            }
            return "Can't Remove Certificate from database";
        }

        public Task<string> UpdateCertificate(CertificateClassify certificateClassify)
        {
            throw new NotImplementedException();
        }
    }
}
