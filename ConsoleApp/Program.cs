using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Services;

Account budi = new SavingAccount("AC001", "Budi", 1000_000);
CurrentAccount ahmad = new("AC002", "Ahmad", 500_000);
ahmad.IsActive = false;

Console.WriteLine("Data Awal");
Console.WriteLine($"{budi.Name} - Balance: {budi.Balance}");
Console.WriteLine($"{ahmad.Name} - Balance: {ahmad.Balance}");

ITransferService transfer = new TransferService();

transfer.Transfer(budi, ahmad, 100000);

Console.WriteLine("Data setelah Transfer");
Console.WriteLine($"{budi.Name} - Balance: {budi.Balance}");
Console.WriteLine($"{ahmad.Name} - Balance: {ahmad.Balance}");
