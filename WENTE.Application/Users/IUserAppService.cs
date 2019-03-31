using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WENTE.Roles.Dto;
using WENTE.Users.Dto;

namespace WENTE.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}