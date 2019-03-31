using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WENTE.PhoneBooks.Dtos;

namespace WENTE.PhoneBooks
{
    public interface IPersonAppService: IApplicationService
    {
        /// <summary>
        /// 分页获取 用户信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据id获取用户信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);
        /// <summary>
        /// 添加或者修改信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);
        /// <summary>
        /// 删除人员信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto dto);
    }
}