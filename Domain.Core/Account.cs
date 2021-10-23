using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        [ForeignKey("ClientOf")]
        [Required]
        public int ClientId { get; set; }
        [Required]
        public Client ClientOf { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
        public List<Transaction> Transactions{ get; set; } = new List<Transaction>();
    }
}
