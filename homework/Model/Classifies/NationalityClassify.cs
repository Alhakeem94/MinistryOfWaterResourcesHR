namespace HR.Models.Classifies
{
    public class NationalityClassify
    {
       
        public int id { get; set; }

        //الجنسية
        public string NationalityName { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
