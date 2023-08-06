namespace HR.Models.Classifies
{
    public class SpecializationClassify
    {
       

        public int Id { get; set; }

        // الاختصاص
        public string Specialization { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
