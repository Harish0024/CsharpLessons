using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace FirstMVCApp.Models
{
    public class Enitity
    {
        //        Movie(Id Int, Title varchar(30),[Language] varchar(30),Hero varchar(20),Director varchar(20),
        //MusicDirector varchar(20),ReleaseDate date, Cost int,Collection int,Review varchar(100));
        [Key]//validation / analaterators(field of class are decerated)

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(1, 20000)]
        public int Id { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Title { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string language { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Hero { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Director { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string MusicDirector { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public int Cost { get; set; }
        

        public int Collection { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Review { get; set; }
       
    }
}
