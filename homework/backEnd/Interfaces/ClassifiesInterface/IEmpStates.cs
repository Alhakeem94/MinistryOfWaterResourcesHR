using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IEmpStates
    {
        public Task<string> AddNewEmpstates(EmpStatesClassify empStatesClassify);
        public Task<string> RemoveNewEmpstates(int id);
        public Task<string> UpdateNewEmpstates(EmpStatesClassify empStatesClassify);
    }
}
