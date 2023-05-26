﻿using HospitalManagementSystem.Models.Common;

namespace HospitalManagementSystem.Models
{
    public class MedicineReport:BaseEntity
    {
        public Supplier? Supplier { get; set; }
        public int SupplierId { get; set; }
        public Medicine? Medicine { get; set; }
       
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public string? Company { get; set; }
        public string? Country { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}
