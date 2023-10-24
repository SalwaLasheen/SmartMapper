namespace Domain
{
    public class EmployeeWsdlRequest
    {
      public int EmpId { get; set; }
      public string FName { get; set; }
      public string LName { get; set; }
      public string Email { get; set; }
      public string phone { get; set; }
      public virtual IEnumerable<AddressModel> Addresses { get; set; }=new List<AddressModel>();   
    }
}
