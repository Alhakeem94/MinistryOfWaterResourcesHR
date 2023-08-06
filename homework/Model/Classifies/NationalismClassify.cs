namespace HR.Models.Classifies
{
    public class NationalismClassify
    {
       
        public int id { get; set; }

        //القومية
        public string Nationalism { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
