namespace Herança.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) //virtual para indicar que a classe pode ser sobreescrita na subclasse
        {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
