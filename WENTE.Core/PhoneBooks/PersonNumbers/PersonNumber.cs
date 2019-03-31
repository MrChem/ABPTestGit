using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using WENTE.PhoneBooks.Persons;

namespace WENTE.PhoneBooks.PersonNumbers
{
    public class PersonNumber :Entity<long> ,IHasCreationTime
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberType type { get; set; }

        public int personId { get; set; }

        public Person person { get; set; }
    }
}
