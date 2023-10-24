using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Mapping;
using Domain;

namespace DTOs
{
    [AutoMap(typeof(AddressModel), ReverseMap = true)]
    public class AddressDto : IMapFrom<AddressModel>
    {
        [SourceMember(nameof(AddressModel.id))]
        public int AddressId { get; set; }
        [SourceMember(nameof(AddressModel.Address1))]
        public string HomeAddress { get; set; }
        [SourceMember(nameof(AddressModel.Address2))]
        public string WorkAddress { get; set; }
        [SourceMember(nameof(AddressModel.Address3))]
        public string AddditionalAddress { get; set; }
    }
}