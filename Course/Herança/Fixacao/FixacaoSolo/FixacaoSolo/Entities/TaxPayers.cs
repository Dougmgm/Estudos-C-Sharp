namespace FixacaoSolo.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public TaxPayers(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
