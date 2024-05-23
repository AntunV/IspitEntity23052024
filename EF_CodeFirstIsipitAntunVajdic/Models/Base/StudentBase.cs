using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirstIsipitAntunVajdic.Models.Base
{
    public abstract class StudentBase
    {
       
       [Key]
     public int StudentId { get; set; }

        [Required]
     public string StudentName { get; set; }
        [Required]
     public DateTime DateOfBirth { get; set; }


     public decimal Height { get; set; }

     public float Weight { get; set; }
    
    
    }
}
