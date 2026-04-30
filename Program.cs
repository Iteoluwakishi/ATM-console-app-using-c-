using System;

namespace ATMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SETUP: Create your Bank Account ---");
            Console.Write("Set a new PIN: ");
            string? newPin = Console.ReadLine();

            // Initialize the account with the new PIN
            BankAccount userAccount = new BankAccount(1000.00m, newPin ?? "0000");

            Console.WriteLine("\n--- Login ---");
            Console.Write("Enter your PIN: ");
            string? inputPin = Console.ReadLine();

            // Verify the PIN
            if (!userAccount.VerifyPin(inputPin ?? ""))
            {
                Console.WriteLine("Incorrect PIN. Access Denied.");
                return;
            }

            Console.WriteLine("Access Granted.");
            
            // ... (The rest of your menu loop remains the same)
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Exit");
                Console.Write("Select an option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Current Balance: {userAccount.GetBalance():C}");
                        break;
                    case "2":
                        Console.Write("Enter amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal dep)) userAccount.Deposit(dep);
                        break;
                    case "3":
                        Console.Write("Enter amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal with)) userAccount.Withdraw(with);
                        break;
                    case "4":
                        running = false;
                        break;
                }
            }
        }
    }
}