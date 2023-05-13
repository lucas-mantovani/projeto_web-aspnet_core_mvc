using mvc_project.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Models.ViewModels
{
    public class SaleFormViewModel
    {
        public SalesRecord salesRecord { get; set; }
        public ICollection<Seller> sellers { get; set; }
        public SaleStatus saleStatus { get; set; }

    }
}
