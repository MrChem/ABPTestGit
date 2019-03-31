using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using WENTE.Dto;

namespace WENTE.PhoneBooks.Dtos
{
    public class GetPersonInput : PageAndSortedInputDto, IShouldNormalize
    {
        void IShouldNormalize.Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "id";
            }
        }

        public string FilterText { get; set; }
    }
}
