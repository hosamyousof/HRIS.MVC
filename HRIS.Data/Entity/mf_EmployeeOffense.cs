using Repository;
using System;

namespace HRIS.Data.Entity
{
    public class mf_EmployeeOffense : EntityBase
    {
        public Guid employeeId { get; set; }
        public Guid offenseId { get; set; }
        public DateTime offenseDate { get; set; }
        public DateTime? memoDate { get; set; }
        public Guid penaltyTypeId { get; set; }
        public int frequency { get; set; }
        public int degree { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string remarks { get; set; }
        public Guid updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        public virtual mf_Offense mf_Offense { get; set; }
        public virtual mf_PenaltyType mf_PenaltyType { get; set; }
        public virtual sys_User sys_User { get; set; }

        public mf_EmployeeOffense()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
        }
    }
}