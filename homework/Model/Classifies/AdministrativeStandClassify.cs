namespace HR.Models.Classifies
{
    public class AdministrativeStandClassify
    {
        public int Id { get; set; }

        // رمز الحالة الوظيفية
        public int EmpStatsId { get; set; }

        //الموقف الاداري
        public string? AdministrativeSituation;

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }


    }
}
