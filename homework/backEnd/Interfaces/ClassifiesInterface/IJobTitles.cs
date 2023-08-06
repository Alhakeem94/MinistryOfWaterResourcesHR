using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IJobTitles
    {
        public Task<string> AddjobTitle(JobTitlesClassify jobTitles);
        public Task<string> RemovejobTitle(int id);
        public Task<string> UpdatejobTitle(JobTitlesClassify jobTitles);
    }
}
