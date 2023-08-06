namespace HR.Models.Classifies
{
    public class DocumentTypeClassify
    {
       
        public int Id { get; set; }

        //نوع الوثيقة
        public string DocumentType { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
