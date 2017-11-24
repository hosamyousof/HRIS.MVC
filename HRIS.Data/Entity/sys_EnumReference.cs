using Repository;

namespace HRIS.Data
{
    public partial class sys_EnumReference : EntityBaseCompany
    {
        public string name { get; set; }
        public int value { get; set; }
        public string description { get; set; }
        public int displayOrder { get; set; }
        public bool hidden { get; set; }
        public string field1 { get; set; }
        public string field2 { get; set; }
        public string field3 { get; set; }
        public string field4 { get; set; }
        public string field5 { get; set; }

        public virtual sys_Company sys_Company { get; set; }

        public sys_EnumReference()
        {
            displayOrder = 0;
            hidden = false;
            deleted = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}