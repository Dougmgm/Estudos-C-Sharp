namespace Herança.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRates { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) :base(number, holder, balance)
        {
            InterestRates = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRates;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }


    }
}
