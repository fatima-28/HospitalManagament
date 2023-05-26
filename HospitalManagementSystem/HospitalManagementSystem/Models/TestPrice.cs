using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class TestPrice:BaseEntity
    {
        public string? TestCode { get; set; }
        public decimal Price { get; set; }
        public Labaratory? Labaratory { get; set; }
        public Bill? Bill { get; set; }
       
    }
}
