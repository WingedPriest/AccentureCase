using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class CreditCardTransaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        [ForeignKey("CreditСardOf")]
        [Required]
        public int CreditСardId { get; set; }
        [Required]
        public DebitСard CreditСardOf { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
    }
}
