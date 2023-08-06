namespace HR.Models.Classifies
{
    public class LanguageClassify
    {
        

        public int Id { get; set; }

        public string Language { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
