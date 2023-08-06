namespace HR.Models.Classifies
{
    public class EmpStatesClassify
    {
        public int Id { get; set; }

        //الحالة الوظيفية
        public string EmpStates { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
