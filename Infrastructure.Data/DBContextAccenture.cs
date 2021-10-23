using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Core;


namespace Infrastructure.Data
{
    public class DBContextAccenture : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<CreditCardTransaction> CreditCardTransactions{ get; set; }
        public DbSet<DebitCardTransactions> DebitCardTransactions { get; set; }
        public DbSet<DebitСard> DebitСards { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DBContextAccenture()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BOBS0F0;Database=DataBaseBankPred;Integrated Security=True");
        }
    }
}
