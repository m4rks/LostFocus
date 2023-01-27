using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostFocus.Models.SearchCriteria
{
    public class ProductSearchCriteria : SearchCriteria
    {
        public string Description { get; set; }
        public string Color { get; set; }
        public decimal? FromPrice { get; set; }
        public decimal? ToPrice { get; set; }
    }
}
