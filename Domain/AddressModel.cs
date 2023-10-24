namespace Domain
{
    public class AddressModel
    {
        public int id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public virtual EmployeeWsdlRequest EmployeeWsdlRequest { get; set; } = new EmployeeWsdlRequest();
    }
}