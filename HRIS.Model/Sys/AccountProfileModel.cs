using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class AccountProfileModel
    {
        [DisplayName("Company")]
        public string company { get; set; }

        [DisplayName("Username")]
        public string username { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DisplayName("Current Password")]
        public string password { get; set; }

        [DisplayName("New Password")]
        public string newPassword { get; set; }
    }
}