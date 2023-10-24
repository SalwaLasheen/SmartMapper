using AutoMapper;
using Domain;
using DTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace SmartMappingAPI
{
    public static class EmployeeEndPoint
    {
        public static void MapEmployeeEndPoints(this IEndpointRouteBuilder builder)
        {
            #region UsingJson

            builder.MapGet("/GetEmployeeByIdJs/{id}", (int employeeId, IMapper mapper) =>
            {

                var wsdlEmployeeRequest = SeedWsdlEmployeesData().First(x => x.EmpId == employeeId);

                var serialWsdlrequest = JsonConvert.SerializeObject(wsdlEmployeeRequest);
                var secureEmployee = JsonConvert.DeserializeObject<EmployeeSecureRequestJson>(serialWsdlrequest);
                return Results.Ok(secureEmployee);
            }).WithName("GetEmployeeByIdJson");

            #endregion

            #region UsingAutoMapper

            builder.MapGet("/GetEmployeeByIdMapper/{id}", (int employeeId, IMapper mapper) =>
            {

                var wsdlEmployee = SeedWsdlEmployeesData().First(x => x.EmpId == employeeId);      
                var empDto = mapper.Map<EmployeeWsdlRequest, EmployeeSecureRequestMapper>(wsdlEmployee);
                return Results.Ok(empDto);
            }).WithName("GetEmployeeByIdMapper");

            #endregion







            builder.MapGet("/GetAllEmployees", (IMapper mapper) =>
            {

                var allEmployeesDto = mapper.Map<List<EmployeeWsdlRequest>, List<EmployeeSecureRequestJson>>(SeedWsdlEmployeesData());

                return Results.Ok(allEmployeesDto);
            }).WithName("GetAllEmployees"); ;


            SeedWsdlEmployeesData();


        }
        private static List<EmployeeWsdlRequest> SeedWsdlEmployeesData()
        {
            var employess = new List<EmployeeWsdlRequest>()
{
    new EmployeeWsdlRequest() { EmpId = 1,Email="Ahmed@Gmail.com",LName="Amed",FName="Omar",phone="01006098868" ,Addresses= new List<AddressModel>
    {
        new AddressModel
        {
            id = 101,
            Address1="SMART Village",
            Address2="orange smart",
            Address3="orange sphinx"
        }
    }
       },
    new EmployeeWsdlRequest() { EmpId = 2,Email="Maged@Gmail.com",LName="Maged",FName="Alaa",phone="01006794768" ,Addresses= new List<AddressModel>
    {
        new AddressModel
        {
            id = 100,
            Address1="SMART Village",
            Address2="orange smart",
            Address3="orange sphinx"
        }
    }
       },
    new EmployeeWsdlRequest() { EmpId = 3,Email="Amr@Gmail.com",LName="Amr",FName="Kamal",phone="01006794768",Addresses= new List<AddressModel>
    {
        new AddressModel
        {
            id = 105,
            Address1="SMART Village",
            Address2="orange smart",
            Address3="orange sphinx"
        }
    }

    }
    };

            return employess;
        }
    }

}
