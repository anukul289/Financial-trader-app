using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTrader.EntityFramework
{
    public class FinancialTraderDbContextFactory : IDesignTimeDbContextFactory<FinancialTraderDbContext>
    {
        public FinancialTraderDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<FinancialTraderDbContext>();
            options.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=FinancialTraderDB;Trusted_Connection=True;");
        
            return new FinancialTraderDbContext(options.Options);
        }
    }
}
