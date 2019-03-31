using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using WENTE.PhoneBooks.Dtos;
using WENTE.PhoneBooks.Persons;

namespace WENTE.PhoneBooks
{
    public class PersonAppService : WENTEAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Persons.Person> _personRepository;

        public PersonAppService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        async Task IPersonAppService.CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }


        }

        async Task IPersonAppService.DeletePersonAsync(EntityDto dto)
        {
            var entity = _personRepository.Get(dto.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("数据不存在");
            }
            else
            {
                await _personRepository.DeleteAsync(dto.Id);
            }


        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        async Task<PagedResultDto<PersonListDto>> IPersonAppService.GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepository.GetAll();
            var personCount = query.Count();
            var persons = query.OrderBy(input.Sorting).PageBy(input).ToList();
            var dtos = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount, dtos);

        }

        async Task<PersonListDto> IPersonAppService.GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAsync(input.Id.Value);
            return person.MapTo<PersonListDto>();


        }

        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRepository.GetAsync(input.id.Value);
            await _personRepository.UpdateAsync(input.MapTo(entity));
        }

        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            _personRepository.Insert(input.MapTo<Person>());
        }

    }
}
