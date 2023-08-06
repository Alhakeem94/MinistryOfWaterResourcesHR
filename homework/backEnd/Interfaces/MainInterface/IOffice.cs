using homework.Model.MainClass;

namespace homework.backEnd.Interfaces.MainInterface
{
    public interface IOffice
    {
        public Task<string> AddOffice(OfficeModel officeModel);
        public Task<string> RemoveOffice(int id);
        public Task<string> UpdateOffice(OfficeModel officeModel);
        public Task<List<OfficeModel>> GetAllOffices();
    }
}
