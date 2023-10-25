using Domain;
using Newtonsoft.Json;

namespace DTOs
{
    public class EmployeeSecureRequestJson
    {

        [JsonProperty(nameof(EmployeeWsdlRequest.EmpId))]
        public int EmployeeId { get; set; }
        [JsonProperty(nameof(EmployeeWsdlRequest.FName))]
        public string FirstName { get; set; }
        [JsonProperty(nameof(EmployeeWsdlRequest.LName))]
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonProperty(nameof(EmployeeWsdlRequest.phone))]
        public string Phonenumber { get; set; }
        [JsonProperty(nameof(EmployeeWsdlRequest.Addresses))]
        public ICollection<AddressDtoJson> Address { get; set; }
    }
}
