using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class mf_EmployeeWorkHistory : EntityBase
    {
        public int employeeId { get; set; }
        public string companyName { get; set; }
        public string position { get; set; }
        public int joinedMonth { get; set; }
        public int joinedYear { get; set; }
        public int? resignedMonth { get; set; }
        public int? resignedYear { get; set; }
        public bool? isPresent { get; set; }
        public int updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public virtual mf_Employee mf_Employee { get; set; }
        

        public mf_EmployeeWorkHistory()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}