using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IMaritalStatus
    {
        public Task<string> Addmaritalstatus(MaritalStatusClassify MaritalStatusClassify);
        public Task<string> Removemaritalstatus(MaritalStatusClassify maritalStatus);
        public Task<string> Updatemaritalstatus(MaritalStatusClassify maritalStatus);
    }
}
