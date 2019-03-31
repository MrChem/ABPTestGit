using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace WENTE.PhoneBooks.Persons
{
    /// <summary>
    /// 人员信息
    /// </summary>
    public class Person:FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [MaxLength(200)]
        [EmailAddress]
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
      [MaxLength(200)]
        public virtual string Address { get; set; }
    }
}
