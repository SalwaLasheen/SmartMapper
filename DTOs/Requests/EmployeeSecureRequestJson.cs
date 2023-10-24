using Newtonsoft.Json;

namespace DTOs
{
    public class EmployeeSecureRequestJson
    {

        [JsonProperty("EmpId")]
        public int EmployeeId { get; set; }
        [JsonProperty("FName")]
        public string FirstName { get; set; }
        [JsonProperty("LName")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phonenumber { get; set; }
    }
}
