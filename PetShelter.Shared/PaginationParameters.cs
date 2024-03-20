using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Shared
{
    public class PaginationParameters
    {
        public const int MaxPageSize = 100;
        public const int DefaultPageSize = 10;
        public const int DefaultPageNumber = 1;

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
