using Repository;
using System;

namespace HRIS.Data
{
    public partial class ta_ApplicationRequestGatePass : EntityBase
    {
        public int applicationRequestId { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }

        public virtual ta_ApplicationRequest ta_ApplicationRequest { get; set; }

        public ta_ApplicationRequestGatePass()
        {
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}