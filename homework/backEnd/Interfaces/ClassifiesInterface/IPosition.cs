using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IPosition
    {
        public Task<string> AddPosition(PositionClassify position);
        public Task<string> RemovePosition(int id);
        public Task<string> UpdatePosition(PositionClassify position);
    }
}
