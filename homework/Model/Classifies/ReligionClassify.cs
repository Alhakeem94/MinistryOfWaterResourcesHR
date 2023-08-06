namespace HR.Models.Classifies
{
    public class ReligionClassify
    {
       

        public int id { get; set; }

        //الديانة
        public string ReligionName { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
