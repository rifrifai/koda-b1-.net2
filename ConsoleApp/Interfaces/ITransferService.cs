using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Models;

namespace ConsoleApp.Interfaces;
public interface ITransferService
{
	void Transfer(Account source, Account destination, decimal amount);
}