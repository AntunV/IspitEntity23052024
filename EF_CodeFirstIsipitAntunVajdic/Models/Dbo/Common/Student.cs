using System.ComponentModel.DataAnnotations;
using EF_CodeFirstIsipitAntunVajdic.Models.Base;

namespace EF_CodeFirstIsipitAntunVajdic.Models.Dbo.Common
{
    public class Student : StudentBase
    {
        [Key]
        public ICollection<Grade> Grades { get; set; }



    }
}
