using SecureLayer.Mapping;

namespace DTOs
{

    public class EmployeeSecureRequestMapster : BaseDto<EmployeeSecureRequestMapster, EmployeeSecureRequestMapster>
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
    }
}
