using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shampaz
{
    public class ReportRow
    {
        public int FactorId { get; set; }
        public string FactorTotalPrice { get; set; }
        public string FactorDate { get; set; }
        public string PersonName { get; set; }
        public string PersonMobile { get; set; }
        public string PersonAddress { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string itemPrice { get; set; }
        public string ItemTotalPrice { get; set; }
        public string Description { get; set; }
    }
}
