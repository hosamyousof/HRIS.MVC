using HRIS.Model.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    public class CompanyModel
    {
        public CompanyModel()
        {
            this.CountryList = new List<CountryModel>();
        }

        [Required]
        [DisplayName("Code")]
        public string code { get; set; }

        [Required]
        [DisplayName("Business name")]
        public string businessName { get; set; }

        [DisplayName("Address 1")]
        public string address1 { get; set; }

        [DisplayName("Address 2")]
        public string address2 { get; set; }

        [DisplayName("Address 3")]
        public string address3 { get; set; }

        [Required]
        [DisplayName("Company")]
        public int countryId { get; set; }

        [DisplayName("City")]
        public string city { get; set; }

        [DisplayName("Postal Code")]
        public string postalCode { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Telephone")]
        public string telephone { get; set; }

        [DisplayName("Mobile")]
        public string mobile { get; set; }

        [DisplayName("Fax")]
        public string fax { get; set; }

        public List<CountryModel> CountryList { get; set; }
    }
}