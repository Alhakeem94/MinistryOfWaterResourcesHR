namespace HR.Models.Classifies
{
    public class GovernorateClassify
    {
        public int id { get; set; }

        //المحافظة
        public string GovernorateName { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
