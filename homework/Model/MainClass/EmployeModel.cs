using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace homework.Model.MainClass
{
    public class EmployeModel
    {


        public int Id { get; set; }


        [Required,MaxLength(14),MinLength(14,ErrorMessage ="*") ]
        //الرقم الوظيفي
        public string EmpNumber { get; set; }

        [Required,MaxLength(60,ErrorMessage ="*")]
        //الإسم الأول
        public string FirstName { get; set; }

        [Required, MaxLength(60, ErrorMessage = "*")]
        //الإسم الثاني
        public string SecondName { get; set; }

        [Required, MaxLength(60, ErrorMessage = "*")]
        //الأسم الثالث
        public string ThirdName { get; set; }

        [Required, MaxLength(60, ErrorMessage = "*")]
        //الإسم الرابع
        public string FourthName { get; set; }
        [Required, MaxLength(20, ErrorMessage = "*")]
        //اللقب
        public string Title { get; set; }
        //صورة المنتسب
        public string? EmpPicture { get; set; }
        [Required ,MaxLength(20,ErrorMessage ="*"),MinLength(20,ErrorMessage ="*")]
        //الرقم المدني
        public int EmpCivilNum { get; set; }
        [Required]
        // المنصب
        public int EmpPosition { get; set; }
        [Required]
        // تأريخ إستلامه المنصب
        public DateTime PositionStartDate { get; set; }
        [Required]
        //رقم أمر المنصب
        public int PositionOrderNum { get; set; }
        [Required]
        [ForeignKey("Department")]
        //القسم
        public int Department { get; set; }
        [Required]
        //الموقع الجغرافي للعمل
        public int GeoLocation { get; set; }
        [Required]
        //طبيعة المهنة
        public int CareerType { get; set; }
        [Required]
        //العنوان الوظيفي
        public int JobTitle { get; set; }
        [Required]
        //الدرجة الوظيفية
        public int JobDegree { get; set; }
        [Required]
        //المرتبة
        public int JobDegreeSection { get; set; }
        [Required]
        //تأريخ التعيين
        public DateTime JobHiretDate { get; set; }
        [Required]
        //رقم أمر التعيين
        public int JobOrderNum { get; set; }
        [Required]
        //تأريخ المباشرة
        public DateTime JobStartDate { get; set; }
        [Required]
        //رقم أمر المباشرة
        public int DirectOrderNum { get; set; }
        [Required]
        //تأريخ أمر المباشرة
        public DateTime DirectDate { get; set; }
        [Required]
        //تأريخ إستحقاق العلاوة
        public DateTime BounsDeserveDate { get; set; }
        [Required]
        //الخدمة المضافة بالسنة
        public int ServiceAddedPerYear { get; set; }
        [Required]
        //الخدمة المضافة بالشهر
        public int ServiceAddedPerMonth { get; set; }
        [Required]
        //الخدمة المضافة باليوم
        public int ServiceAddedPerDay { get; set; }
        [Required]
        //الخدمة المحذوفة بالسنة
        public int ServiceDeletedPerYear { get; set; }
        [Required]
        //الخدمة المحذوفة بالشهر
        public int ServiceDeletedPerMonth { get; set; }
        [Required]
        //الخدمة المحذوفة باليوم
        public int ServiceDeletedPerDay { get; set; }
        [Required]
        //ملاحظات الخدمة
        public string ServiceNotes { get; set; }
        [Required]
        //الحالة الوظيفية
        public int EmpState { get; set; }
        [Required]
        //الموقف الإداري
        public int AdministrativePosition { get; set; }
        [Required]
        //رقم أمر الحالة الوظيفية
        public int EmploymentStatusOrderNumber { get; set; }
        [Required]
        //تأريخ أمر الحالة الوظيفية
        public DateTime EmploymentStatusOrderDate { get; set; }
        [Required]
        //تأريخ الإنفكاك
        public DateTime BreakupDate { get; set; }
        [Required]
        //الدائرة المكلف منها
        public string OfficeAssignedTo { get; set; }
        [Required]
        //الشهادة الحالية
        public int CurrentCertificate { get; set; }
        [Required]
        //التخصص
        public int EmpSpecialization { get; set; }
        [Required]
        //سنة التخرج
        public DateTime GraduationYear { get; set; }
        [Required]
        //الجامعة والكلية
        public string EmpCollage { get; set; }
        [Required]
        //المحافظة
        public int EmpGovernorate { get; set; }
        [Required]
        //الحي
        public string EmpDistrict { get; set; }
        [Required]
        //الزقاق
        public int EmpAlley { get; set; }
        [Required]
        //المحلة
        public int Emplocality { get; set; }
        [Required]
        //رقم الدار
        public int HouseNumber { get; set; }
        [Required]
        //رقم الهاتف
        public int PhoneNumber { get; set; }
        [Required]
        //حالة السكن
        public int HousingState { get; set; }
        [Required]
        //نوع السكن
        public int HouseType { get; set; }
        [Required]
        //الجنس
        public int EmpGender { get; set; }
        [Required]
        //محل الولادة
        public int BirthPlace { get; set; }
        [Required]
        //تأريخ الولادة
        public DateTime BirthDate { get; set; }
        [Required]
        //القومية
        public int EmpNationalism { get; set; }
        [Required]
        //الديانة
        public int EmpReligion { get; set; }
        [Required]
        //الجنسية
        public int EmpNationality { get; set; }
        [Required]
        //الحالة الزوجية
        public int MaritalStatus { get; set; }
        [Required]
        //إسم الزوجة أو الزوج إن وجد
        public string WifeHusbandName { get; set; }
        [Required]
        //جنسية الزوجة أو الزوج
        public int WifeHusbandNationality { get; set; }
        [Required]
        //عدد الأطفال
        public int NumOfKids { get; set; }
        [Required]
        //مهنة/الزوج/الزوجة
        public string WifeHusbandCarrer { get; set; }
        [Required]
        //إسم الأم
        public string MotherName { get; set; }
        [Required]
        //رقم شهادة الجنسية
        public int NationalityCertificateNumber { get; set; }
        [Required]
        //تأريخ شهادة الجنسية
        public DateTime CitizenshipCertificateDate { get; set; }
        [Required]
        //رقم هوية الأحوال المدنية
        public int CivilStatusIdentificationNumber { get; set; }
        [Required]
        //تأريخ أصدار الأحوال المدنية
        public DateTime CitizenshipCertificateIssueDate { get; set; }
        [Required]
        //رقم البطاقة الوطنية الموحدة
        public int UnifiedNationalCardNumber { get; set; }
        [Required]
        // تأريخ إصدار البطاقة الوطنية الموحدة
        public DateTime UnifiedIssueDate { get; set; }
        [Required]
        //جهة الإصدار
        public string Issuer { get; set; }
        [Required]
        //رقم البطاقة التموينية
        public int RationCardNumber { get; set; }
        [Required]
        //إسم المركز التمويني
        public string FoodNameCenter { get; set; }
        [Required]
        // الملاحظات
        public string EmpNotes { get; set; }
        [Required]
        // تأريخ التحديث	
        public DateTime LastUpdate { get; set; }
        [Required]
        //أسم المستخدم	
        public int UserName { get; set; }

        public DepartmentModel departmentTabel { get; set; }
    }
}
