using System.ComponentModel.DataAnnotations;

namespace Lab06.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Email bắt buộc phải được nhập")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 8)]
        [Required]
        public string? Password { get; set; }

        [Required]
        public string? Branch { get; set; }

        [Required]
        public string? Gender { get; set; }

        public bool IsRegular { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Dob { get; set; }
    }
}
