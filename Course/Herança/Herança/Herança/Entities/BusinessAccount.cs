namespace Herança.Entities
{
    class BusinessAccount : Account //Business herda de Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) //base para chamar o construtor da classe "Account" e reutiliza os dados
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            } 
        }
    }
}
