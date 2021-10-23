using System;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GenerateCSV
{
    public class Client
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime CreateDateTime { get; set; }

        public static void CreateCSVClient()
        {
            List<Client> clients = new List<Client>();
            for (int i = 0; i < 50000; i++)
            {
                string gend;
                if (new Random().Next(0, 2) == 1) gend = "M"; else gend = "F";
                clients.Add(new Client()
                {
                    Id = i + 1,
                    Surname = "agasgagasgag",
                    Name = "asdasfasf",
                    LastName = "asdasfafasdas",
                    Age = new Random().Next(16, 92),
                    Gender = gend,
                    MaritalStatus = "Single",
                    CreateDateTime = DateTime.Now
                }) ;
            }
            using (var writer = new StreamWriter("D:\\Clients.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(clients);
            }
        }

    }
    public class Account
    {

        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public DateTime CreateDateTime { get; set; }
        public static void CreateCSVClient()
        {
            List<Account> clients = new List<Account>();
            for (int i = 0; i < 50000; i++)
            {
                string gend;
                if (new Random().Next(0, 2) == 1) gend = "RUB"; else gend = "USD";
                clients.Add(new Account()
                {
                    Id = i + 1,
                    ClientId= new Random().Next(1, 50000),
                    Balance= new Random().Next(1, 500000),
                    Currency=gend,
                    CreateDateTime = DateTime.Now
                });
            }
            using (var writer = new StreamWriter("D:\\Accounts.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(clients);
            }
        }
        
    }
    public class CreditCard
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string NumCard { get; set; }
        public DateTime Date { get; set; }
        public string CVV { get; set; }
        public decimal Balance { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime CreateDateTime { get; set; }
        public static void CreateCSVClient()
        {
            List<CreditCard> clients = new List<CreditCard>();
            for (int i = 0; i < 50000; i++)
            {
                clients.Add(new CreditCard()
                {
                    Id = i + 1,
                    ClientId = new Random().Next(1, 25000),
                    Balance = new Random().Next(1, 500000),
                    NumCard = new Random().Next(1000, 9999).ToString() + " " + new Random().Next(1000, 9999).ToString() + " " + new Random().Next(1000, 9999).ToString() + " " + new Random().Next(1000, 9999).ToString(),
                    CreateDateTime = Convert.ToDateTime("08-12"),
                    CVV = new Random().Next(100, 999).ToString(),
                    CreditLimit = new Random().Next(1, 500000),
                }) ;
            }
            using (var writer = new StreamWriter("D:\\CreditCards.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(clients);
            }
        }

    }
    public class Passport
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public string Satus { get; set; }
        public DateTime DatePassport { get; set; }
        public static void CreateCSVClient()
        {
            List<Passport> clients = new List<Passport>();
            for (int i = 0; i < 50000; i++)
            {
                clients.Add(new Passport()
                {
                    Id = i + 1,
                    ClientId = i + 1,
                    PassportNumber=new Random().Next(100000,999999).ToString(),
                    PassportSeries=new Random().Next(1000,9999).ToString(),
                    Satus="Active",
                    DatePassport=DateTime.UtcNow
                });
            }
            using (var writer = new StreamWriter("D:\\Passports.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(clients);
            }
        }
    }

    class BranchStatistics
    {
        public int Id { get; set; }
        public int BranchId { get; set; }//Номер филиала
        public decimal BalancesheetCurrency { get; set; }//Баланс ввалюты
        public decimal BalanceSheetProfit { get; set; }//Балансовая прибыль
        public decimal LoansLegalEntities { get; set; }//Кредиты юридическим лицам
        public decimal LoansIndividuals { get; set; }//Кредиты физическим лицам
        public decimal FundsLegalEntities { get; set; }//Средства юридических лиц
        public decimal FundsIndividuals { get; set; }//Средства физических лиц
        public decimal DebtObligationsIssued { get; set; }//Выпущенные долговые обязательства
        public decimal NumberEmployees { get; set; }//Численность сотрудников
        public string ReportDate { get; set; }//Дата
        public static void CreateCSVClient()
        {
            List<BranchStatistics> clients = new List<BranchStatistics>();
            int r = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    clients.Add(new BranchStatistics()
                    {
                        Id = r,
                        BranchId = i,
                        BalancesheetCurrency = new Random().Next(700000, 2000000),
                        BalanceSheetProfit=new Random().Next(100000,600000),
                        LoansLegalEntities=new Random().Next(400000,1500000),
                        LoansIndividuals=new Random().Next(100000,800000),
                        FundsLegalEntities = new Random().Next(800000, 1300000),
                        FundsIndividuals= new Random().Next(600000, 1100000),
                        DebtObligationsIssued = new Random().Next(100000, 300000),
                        NumberEmployees = new Random().Next(60, 80),
                        ReportDate=$"2021-{j+1}-09"
                    }) ;
                    r++;
                }
            }
            using (var writer = new StreamWriter("D:\\BranchStatistics.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(clients);
            }
        }
    }
    public class Transaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public string CreateDateTime { get; set; }
        public static void CreateCSVClient()
        {
            List<Transaction> clients = new List<Transaction>();
            int r = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    string type;
                    if (new Random().Next(0, 2) == 1) type = "DEPO"; else type = "CRED";
                    clients.Add(new Transaction()
                    {
                        Id = r,
                        AccountId = new Random().Next(1, 50000),
                        Type=type,
                        Balance=new Random().Next(10, 3000),
                        CreateDateTime = $"2021-{i+1}-{j+1}"
                    }) ;
                    r++;
                }
            }
            using (var writer = new StreamWriter("D:\\Transactions.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(clients);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client.CreateCSVClient();
            Account.CreateCSVClient();
            CreditCard.CreateCSVClient();
            Passport.CreateCSVClient();
            BranchStatistics.CreateCSVClient();
            Transaction.CreateCSVClient();
        }
    }
}
