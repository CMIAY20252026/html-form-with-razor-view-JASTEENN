using System;

class ATMReplica
{
    static void Main()
    {
        decimal balance = 0;
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Simple ATM Replica ===");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter amount to deposit: ");
                    decimal deposit = decimal.Parse(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine($"✅ Deposited: ₱{deposit}");
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid deposit amount.");
                    }
                    break;

                case "2":
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdraw = decimal.Parse(Console.ReadLine());
                    if (withdraw > 0 && withdraw <= balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine($"Withdrawn: ₱{withdraw}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid or insufficient balance.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Current Balance: ₱{balance}");
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
