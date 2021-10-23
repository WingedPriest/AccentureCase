using System;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

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
            // указываем путь к файлу csv
            string pathCsvFile = "D:\\Clients.csv";
            List<Client> clients = new List<Client>();
            for (int i = 0; i < 50000; i++)
            {
                string gend;
                if (new Random().Next(0, 2) == 1) gend = "M"; else gend = "Ж";
                clients.Add(new Client()
                {
                    Id = i + 1,
                    Surname = "agasgagasgag",
                    Name = "asdasfasf",
                    LastName = "asdasfafasdas",
                    Age = new Random().Next(16, 98),
                    Gender = gend,
                    MaritalStatus = "Не женат",
                    CreateDateTime = DateTime.Now
                }) ;
            }

            using (var writer = new StreamWriter(pathCsvFile))
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
            Console.WriteLine("Hello World!");
        }
    }
}
