namespace HR.Models.Classifies
{
    public class DocumentSubjectClassify
    {
       
        public int Id { get; set; }

        // موضوع الوثيقة
        public string DocumentSubject { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
