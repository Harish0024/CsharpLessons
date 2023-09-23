using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCEFApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Speciality { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [Column(TypeName ="numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
    }
}
