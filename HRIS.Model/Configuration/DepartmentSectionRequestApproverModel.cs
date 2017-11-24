using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Configuration
{
    public class DepartmentSectionRequestApproverModel
    {
        public int id { get; set; }

        [DisplayName("Approver Username")]
        public string username { get; set; }

        [DisplayName("Approver Sequence")]
        [UIHint("IntegerTextBox")]
        public int orderNo { get; set; }

        public int userId { get; set; }
    }
}