using System.ComponentModel.DataAnnotations.Schema;

namespace homework.Model.MainClass
{
    public class DepartmentModel
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        [ForeignKey("OfficeTable")]
        public int OfficeTableId { get; set; }

        public OfficeModel OfficeTable { get; set; }
    }
}
