using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IAdministrativeStand
    {
        public Task<string> AddNewAdministrationStand(AdministrativeStandClassify administrativeStandClassify);

        public Task<string> RemoveAdministrationStand(int id);
        public Task<string> UpdateAdministrationStand(AdministrativeStandClassify administrativeStandClassify);
    }
}
