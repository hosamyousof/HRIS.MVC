using Repository;
using System;

namespace HRIS.Data.Entity
{
    public partial class sys_ErrorLog : EntityBase
    {
        public string message { get; set; }
        public string innerException { get; set; }
        public int loggedType { get; set; }
        public string controllerName { get; set; }
        public string actionName { get; set; }
        public string areaName { get; set; }
        public int? createdBy { get; set; }
        public DateTime createdDate { get; set; }

        

        public sys_ErrorLog()
        {
            createdDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}