using homework.Model.MainClass;

namespace homework.backEnd.Interfaces.MainInterface
{
    public interface IEmploye
    {
        public Task<string> AddEmploye(EmployeModel EmployeModel);
        public Task<string> RemoveEmploye(int id);
        public Task<string> UpdateEmploye(EmployeModel employeModel);

        public Task<bool> CheckIfUserExistsInDB(string EmpNumber);
    }
}
