namespace HR.Models.Classifies
{
    public class CertificateClassify
    {
        
        public int Id { get; set; }

        //الشهادة
        public string? Certification;

        //نسبة مخصصات الشهادة
        public int CertificationPercentage { get; set; }

        //مخصصات شهادة عليا
        public int HighCertificationPercentage { get; set; }

        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }

        //أسم المستخدم	
        public int UserName { get; set; }

    }
}
