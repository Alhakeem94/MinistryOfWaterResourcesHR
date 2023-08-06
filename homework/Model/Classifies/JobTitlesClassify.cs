namespace HR.Models.Classifies
{
    public class JobTitlesClassify
    {
        public int Id { get; set; }

        //طبيعة المهنة
        public int ServiceId { get; set; }

        //العنوان الوظيفي
        public string JobTitle { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
