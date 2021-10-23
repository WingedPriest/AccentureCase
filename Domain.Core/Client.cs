using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }
        public string? LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
        public List<Account> Accounts  { get; set; } = new List<Account>();
        public List<DebitСard> debitСards{ get; set; } = new List<DebitСard>();
        public List<CreditCard> creditCards{ get; set; } = new List<CreditCard>();
        public List<Passport> passports { get; set; } = new List<Passport>();
    }
}
