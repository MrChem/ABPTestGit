using System.ComponentModel.DataAnnotations;

namespace WENTE.PhoneBooks.Dtos
{
    public class PersonEditDto
    {
        public int? id { get; set; }

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