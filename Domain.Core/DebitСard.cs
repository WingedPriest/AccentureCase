using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class DebitСard
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
        public string NumCard { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string CVV { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
        public List<DebitCardTransactions> DebitCardTransactions { get; set; } = new List<DebitCardTransactions>();
    }
}
