namespace HR.Models.Classifies
{
    public class PositionClassify
    {
       

        public int Id { get; set; }

        //المنصب
        public string PositionName { get; set; }

        //مخصصات المنصب	
        public int PositionProvisions { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
