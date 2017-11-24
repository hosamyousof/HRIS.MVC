using HRIS.Model.Configuration;
using HRIS.Model.Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HRIS.Model.MasterFile
{
    public class EmployeeBasicInfoModel
    {
        public EmployeeBasicInfoModel()
        {
            this.MaritalStatusList = new List<ReferenceModel>();
            this.GenderList = new List<ReferenceModel>();
            this.CountryList = new List<CountryModel>();
        }

        public int? id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string firstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [DisplayName("Middle Name")]
        public string middleName { get; set; }

        [DisplayName("Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? birthDate { get; set; }

        [DisplayName("Personal Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DisplayName("Marital Status")]
        public int? maritalStatus { get; set; }

        [DisplayName("Gender")]
        public int? gender { get; set; }

        [DisplayName("Contact 1")]
        public string contact1 { get; set; }

        [DisplayName("Contact 2")]
        public string contact2 { get; set; }

        [DisplayName("Contact 3")]
        public string contact3 { get; set; }

        public HttpPostedFileBase image { get; set; }

        #region Address

        [DisplayName("Address 1")]
        public string address1 { get; set; }

        [DisplayName("Address 2")]
        public string address2 { get; set; }

        [DisplayName("Address 3")]
        public string address3 { get; set; }

        [DisplayName("Country")]
        public int countryId { get; set; }

        [DisplayName("City")]
        public string city { get; set; }

        [DisplayName("Postal Code")]
        public string postalCode { get; set; }

        #endregion Address

        public List<ReferenceModel> MaritalStatusList { get; set; }

        public List<ReferenceModel> GenderList { get; set; }

        public List<CountryModel> CountryList { get; set; }

        public string clearImage { get; set; }

        public string pictureExtension { get; set; }
        public bool confidential { get; set; }
    }
}
