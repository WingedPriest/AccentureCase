using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class Transaction
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        [ForeignKey("AccountOf")]
        [Required]
        public int AccountId { get; set; }
        [Required]
        public Account AccountOf { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
    }
}
