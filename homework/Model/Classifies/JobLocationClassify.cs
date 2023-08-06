namespace HR.Models.Classifies
{
    public class JobLocationClassify
    {
       

        public int Id { get; set; }

        //رمز الدائرة
        public int OfficeId { get; set; }

        //مكان العمل
        public string JobLocation { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
