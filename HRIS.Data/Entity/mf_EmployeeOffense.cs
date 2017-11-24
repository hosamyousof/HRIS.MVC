using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeOffense : EntityBase
    {
        public int employeeId { get; set; }
        public int offenseId { get; set; }
        public DateTime offenseDate { get; set; }
        public DateTime? memoDate { get; set; }
        public int penaltyTypeId { get; set; }
        public int frequency { get; set; }
        public int degree { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string remarks { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_Offense mf_Offense { get; set; }
        public virtual mf_PenaltyType mf_PenaltyType { get; set; }
        

        public mf_EmployeeOffense()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}