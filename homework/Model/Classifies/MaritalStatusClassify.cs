namespace HR.Models.Classifies
{
    public class MaritalStatusClassify
    {
       

        public int Id { get; set; }

        //الحالة الزوجية
        public string MaritalStatus { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
