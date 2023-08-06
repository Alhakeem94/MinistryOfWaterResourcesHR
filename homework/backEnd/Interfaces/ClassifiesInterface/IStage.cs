using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IStage
    {
        public Task<string> AddStage(StageClassify stage);
        public Task<string> RemoveStage(StageClassify stage);
        public Task<string> UpdateStage(StageClassify stage);
    }
}
