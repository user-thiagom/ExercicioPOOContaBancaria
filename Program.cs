using ExercicioPOOContaBancaria.Entities;
using ExercicioPOOContaBancaria.Entities.Exceptions;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int accountNumber = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string accountHolder = Console.ReadLine();
Console.Write("Initial balance: ");
double accountBalance = double.Parse(Console.ReadLine());
Console.Write("Withdraw limit: ");
double accountWithdrawLimit = double.Parse(Console.ReadLine());

Account account = new Account(accountNumber,accountHolder,accountBalance,accountWithdrawLimit);

try
{
    Console.Write("Enter amount for withdraw: ");
    account.Withdraw(double.Parse(Console.ReadLine()));
    Console.Write($"New balance: {account.Balance}");
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
