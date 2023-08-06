namespace HR.Models.Classifies
{
    public class GeoLocationClassify
    {
       

        public int Id { get; set; }

        //الموقع الجغرافي للعمل
        public string GeoLocation { get; set; }

        //مخصصات الموقع الجغرافي
        public float GeoLocationFee { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }
    }
}
