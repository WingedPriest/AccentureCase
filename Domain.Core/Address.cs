using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Core
{
    public class Address
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Id { get; set; }
        [ForeignKey("PassportOf")]
        [Required]
        public int PassportId { get; set; }
        [Required]
        public Passport PassportOf { get; set; }
        [Required]
        public string StringAddress { get; set; }
        [Required]
        public string Satus { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
    }
}
