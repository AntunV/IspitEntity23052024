using System.ComponentModel.DataAnnotations.Schema;
using EF_CodeFirstIsipitAntunVajdic.Models.Base;

namespace EF_CodeFirstIsipitAntunVajdic.Models.Dbo.Common
{
    public class Grade : GradeBase
    {
        [ForeignKey("StudentId")]
        public Student Student { get; set; }


    }
}
