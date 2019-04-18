using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class BalanceRepository: IBalanceRepository
    {
        private readonly DatabaseContext _databaseContext;

        public BalanceRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Balance GetCurrentBalance()
        {
            return _databaseContext.Balances.FirstOrDefault();
        }

        public void UpdateBalance(Balance balance)
        {
            var balanceUpdate =
                _databaseContext.Balances.FirstOrDefault(i => i.Id == balance.Id);
            if (balanceUpdate != null)
            {
                balanceUpdate.CurrentBalance = balance.CurrentBalance;

                _databaseContext.Balances.Update(balanceUpdate);
            }

            _databaseContext.SaveChanges();
        }
    }
}
