using homework.Model.MainClass;

namespace homework.backEnd.Interfaces.MainInterface
{
    public interface IDepartment
    {
        public Task<string> AddNewDepartment(DepartmentModel departmentModel);
        public Task<string> RemoveNewDepartment(int id);
        public Task<string> UpdateNewDepartment(DepartmentModel departmentModel);
    }
}
