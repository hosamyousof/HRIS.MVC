using Repository;
using System;
using System.Collections.Generic;

namespace HRIS.Data.Entity
{
    public partial class sys_User : EntityBaseCompany
    {
        public string username { get; set; }
        public string password { get; set; }
        public string hashKey { get; set; }
        public string vector { get; set; }
        public string email { get; set; }
        public Guid? employeeId { get; set; }
        public int status { get; set; }
        public Guid? updatedBy { get; set; }
        public DateTime updatedDate { get; set; }

        public sys_User()
        {
            updatedDate = System.DateTime.Now;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}