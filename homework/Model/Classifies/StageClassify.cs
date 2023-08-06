namespace HR.Models.Classifies
{
    public class StageClassify
    {
      

        public int Id { get; set; }

        //المرتبة
        public string Stage { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
