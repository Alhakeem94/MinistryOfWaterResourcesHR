using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IJobLocation
    {
        public Task<string> Addjoblocation(JobLocationClassify jobLocationClassify);
        public Task<string> Removejoblocation(int id);
        public Task<string> Updatejoblocation(JobLocationClassify jobLocation);
    }
}
