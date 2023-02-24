using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name  + " (used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    
    }
}
