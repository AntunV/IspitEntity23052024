using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirstIsipitAntunVajdic.Models.Base
{
    public class GradeBase
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        public string GradeName { get; set; }
        [Required]
        public string Section { get; set; }

        public int StudentId { get; set; }




    }
}
