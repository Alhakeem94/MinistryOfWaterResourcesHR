using homework.Model.MainClass;
using HR.Models.Classifies;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace homework.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object EmpTable;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<EmployeModel> EmployTable { get; set; }
        public DbSet<OfficeModel> OfficeTable { get; set; }
        public DbSet<DepartmentModel> DeparmentTable { get; set; }
        public DbSet<AdministrativeStandClassify> AdministrativeTable { get; set; }
        public DbSet<CertificateClassify> CertificateTabel{ get; set; }
        public DbSet<DocumentSubjectClassify> DocumentSubjectTable { get; set; }
        public DbSet<DocumentTypeClassify> DocumentTypeTable { get; set; }
        public DbSet<EmpStatesClassify> EmpStatesTable{ get; set; }
        public DbSet<GeoLocationClassify> GeoLocationTable { get; set; }
        public DbSet<GovernorateClassify> GovernoraTable{ get; set; }
        public DbSet<JobDegreeClassify> JobDegreeTable { get; set; }
        public DbSet<JobLocationClassify> JobLocationTable { get; set; }
        public DbSet<JobTitlesClassify> JobTitlesTable { get; set; } 
        public DbSet<LanguageClassify> LanguageTable { get; set; }
        public DbSet<MaritalStatusClassify> MaritalStatusTable { get; set; }
        public DbSet<NationalismClassify> NationalismTable { get; set; }
        public DbSet<NationalityClassify> NationalityTable { get; set; }
        public DbSet<OccupationClassify> OccupationTable { get; set; }
        public DbSet<PositionClassify> PositionTable { get; set; }
        public DbSet<ReligionClassify> ReligionTable { get; set; }
        public DbSet<ServiceClassify> ServiceTable { get; set; }
        public DbSet<ServiceStatusClassify>  ServiceStatusTable{ get; set; }
        public DbSet<ServiceTypeClassify> ServiceTypeTable { get; set; }
        public DbSet<SpecializationClassify> SpecializationTable { get; set; }
        public DbSet<StageClassify> StageTable { get; set; }








    }
}