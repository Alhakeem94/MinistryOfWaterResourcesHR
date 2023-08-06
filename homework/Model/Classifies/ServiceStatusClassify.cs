namespace HR.Models.Classifies
{
    public class ServiceStatusClassify
    {
      

        public int Id { get; set; }

        //حالة الخدمة
        public string ServiceStatus { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
