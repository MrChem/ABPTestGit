using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using WENTE.MultiTenancy;

namespace WENTE.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}