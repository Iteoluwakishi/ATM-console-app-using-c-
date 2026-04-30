namespace ATMApplication
{
    public class BankAccount
    {
        private decimal balance;
        private string _pin; // Field to store the PIN

        // Constructor now requires a PIN
        public BankAccount(decimal initialBalance, string pin)
        {
            balance = initialBalance;
            _pin = pin;
        }

        // Method to verify the PIN
        public bool VerifyPin(string inputPin)
        {
            return _pin == inputPin;
        }

        public decimal GetBalance() => balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited: {amount:C}");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew: {amount:C}");
                return true;
            }
            return false;
        }
    }
}