using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;

namespace ConsoleApp.Services;

public class TransferService : ITransferService
{
	public void Transfer(Account source, Account destination, decimal amount)
	{
		if (!source.IsActive || !destination.IsActive)
		{
			Console.WriteLine("Akun sumber atau akun penerima harus aktif!");
			return;
		}
		if (source.AccountID == destination.AccountID)
		{
			Console.WriteLine("Tidak boleh transfer ke akun sendiri!");
			return;
		}
		if (amount > source.Balance)
		{
			Console.WriteLine("Saldo tidak mencukupi!");
		}
		source.Debit(amount);
		destination.Credit(amount);

		Console.WriteLine($"Berhasil transfer Rp. {amount} dari {source.Name} ke {destination.Name}\n");
	}
}