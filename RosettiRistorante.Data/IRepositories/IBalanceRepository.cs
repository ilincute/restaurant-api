using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    public interface IBalanceRepository
    {
        Balance GetCurrentBalance();
        void UpdateBalance(Balance balance);
    }
}
