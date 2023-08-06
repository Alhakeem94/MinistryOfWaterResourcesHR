using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IJobDegree
    {
        public Task<string> AddJobDgree(JobDegreeClassify jobDegree);
        public Task<string> RemoveJobDgree(int id);

        public Task<string> UpdateJobDgree(JobDegreeClassify jobDegree);
    }
}
