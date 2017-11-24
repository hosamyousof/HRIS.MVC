using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeBasicPay : EntityBase
    {
        public Guid employeeId { get; set; }
        public double basicPay { get; set; }
        public int rateType { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }

        public mf_EmployeeBasicPay()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}