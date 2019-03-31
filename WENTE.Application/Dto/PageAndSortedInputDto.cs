using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace WENTE.Dto
{
    public class PageAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        public int SkipCount { get; set; }
        [Range(0,int.MaxValue)]
        public int MaxResultCount { get; set; }

        [Range(0,500)]
        public string Sorting { get; set; }
    }
}
