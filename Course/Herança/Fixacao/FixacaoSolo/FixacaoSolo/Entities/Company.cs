using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoSolo.Entities
{
    class Company : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double income, int numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10 )
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
