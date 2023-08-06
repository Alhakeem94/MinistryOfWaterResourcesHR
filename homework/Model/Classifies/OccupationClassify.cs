namespace HR.Models.Classifies
{
    public class OccupationClassify
    {

        public int Id { get; set; }

        // طبيعة المهنة
        public string Occupation { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
