using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class Passport
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
        public string PassportNumber { get; set; }
        [Required]
        public string PassportSeries { get; set; }
        [Required]
        public string Satus { get; set; }
        [Required]
        public DateTime DatePassport { get; set; }
        public List<Address> addresses { get; set; } = new List<Address>();
    }
}
