namespace HR.Models.Classifies
{
    public class JobDegreeClassify
    {
      

        public int Id { get; set; }

        //الدرجة الوظيفية
        public string JobDegree { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
