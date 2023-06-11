
namespace BankApp
{
    public class Account
    {
        private const int TRANSIT_NUMBER = 314;
        private static int nextAccountNumber = 1;
        public readonly string Number;

        public double Balance { get; private set; }
        public List<string> Names { get; private set; }

        private Account(string number, string name, double balance)
        {
            Number = number;
            Names = new List<string> { name };
            Balance = balance;
        }

        public Account()
        {
            Number = TRANSIT_NUMBER + "-" + nextAccountNumber++;
            Names = new List<string>();
            Balance = 0;
        }

        public static Account CreateAccount(string name, double balance)
        {
            string number = TRANSIT_NUMBER + "-" + nextAccountNumber++;
            return new Account(number, name, balance);
        }

        public override string ToString()
        {
            return $"Account Number: {Number}, Balance: {Balance:C}, Names: {string.Join(", ", Names)}";
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive", nameof(amount));

            if (Balance - amount < 0)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }

        public void AddName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty or white space", nameof(name));

            Names.Add(name);
        }
    }
}
