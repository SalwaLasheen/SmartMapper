using Domain;
using Newtonsoft.Json;

namespace DTOs
{
    public class AddressDtoJson
    {

        [JsonProperty(nameof(AddressModel.id))]
        public int AddressId { get; set; }
        [JsonProperty(nameof(AddressModel.Address1))]
        public string HomeAddress { get; set; }
        [JsonProperty(nameof(AddressModel.Address2))]
        public string WorkAddress { get; set; }
        [JsonProperty(nameof(AddressModel.Address3))]
        public string AddditionalAddress { get; set; }
    }
}