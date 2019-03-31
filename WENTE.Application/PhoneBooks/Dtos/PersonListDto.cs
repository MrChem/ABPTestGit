using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using WENTE.PhoneBooks.Persons;

namespace WENTE.PhoneBooks.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public virtual string Address { get; set; }
    }
}