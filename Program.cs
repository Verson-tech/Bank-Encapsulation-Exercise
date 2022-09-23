using BankEncapsulationExercise;

BankAccount account = new BankAccount();
Console.WriteLine("Enter the amount to be deposited to your account");
var  amountToDeposit = double.Parse(Console.ReadLine());
account.Deposit(amountToDeposit);
Console.WriteLine($"Your balance is {account.GetBalance()}");
