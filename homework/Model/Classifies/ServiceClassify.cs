namespace HR.Models.Classifies
{
    public class ServiceClassify
    {
       

        public int Id { get; set; }

        //صنف الخدمة 
        public string ServiceName { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
