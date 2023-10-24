using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Mapping;
using Domain;

namespace DTOs
{
    [AutoMap(typeof(EmployeeWsdlRequest), ReverseMap = true)]
    public class EmployeeSecureRequestMapper : IMapFrom<EmployeeWsdlRequest>
    {

        [SourceMember(nameof(EmployeeWsdlRequest.EmpId))]
        public int EmployeeId { get; set; }
        [SourceMember(nameof(EmployeeWsdlRequest.FName))]
        public string FirstName { get; set; }
        [SourceMember(nameof(EmployeeWsdlRequest.LName))]
        public string LastName { get; set; }
        public string Email { get; set; }
        [SourceMember(nameof(EmployeeWsdlRequest.phone))]
        public string Phonenumber { get; set; }
        [SourceMember(nameof(EmployeeWsdlRequest.Addresses))]
        public virtual IEnumerable<AddressDto> AddressesDto { get; set; }
    }
}
