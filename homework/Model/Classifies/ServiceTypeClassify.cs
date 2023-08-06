namespace HR.Models.Classifies
{
    public class ServiceTypeClassify
    {
       

        public int Id { get; set; }

        //نوع الخدمة
        public string ServiceType { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
