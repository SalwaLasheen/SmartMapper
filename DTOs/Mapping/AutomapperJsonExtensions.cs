/*using AutoMapper;
using System.Data;


using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;


namespace DTOs.Mapping
{
    public static class AutomapperJsonExtensions
    {
        static readonly IContractResolver defaultResolver = new JsonSerializer().ContractResolver;

        public static void CreateJsonDataReaderMap<TDestination>(this IMapperConfigurationExpression cfg, IContractResolver resolver = null)
        {
            resolver = resolver ?? defaultResolver;
            var contract = resolver.ResolveContract(typeof(TDestination)) as JsonObjectContract ?? throw new ArgumentException(string.Format("{0} is not a JSON object.", typeof(TDestination)));

            var map = cfg.CreateMap<IDataRecord, TDestination>();

            foreach (var p in contract.Properties.Where(p => !p.Ignored && p.Writable))
            {
                // Map PropertyName in reader to UnderlyingName in TDestination
                map.ForMember(p.UnderlyingName, opt => opt.MapFrom(r => r[p.PropertyName]));
            }
        }
    }
}
*/