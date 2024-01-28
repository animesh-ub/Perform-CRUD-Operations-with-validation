using System.ComponentModel.DataAnnotations;

namespace StudentValidation.Models
{
    public class Student {

        [Required(ErrorMessage = "Please provide Id")]
        //[UniqueAnswerOnly]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide Name")]
        [MinLength(3, ErrorMessage = "Minimum 3 alphabets are required")]
        [StringLength(30, ErrorMessage = "Minimum ")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Only Alphabets allowed")]

        public string Name { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/2002", "01/01/2008", ErrorMessage = "Date of birth must be between 01/01/2002 and 01/01/2008")]
        public DateTime Dob { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "Batch must be of length 4")]
        [RegularExpression(@"^B\d{3}$", ErrorMessage = "Batch shall start from B and last three characters shall be integers")]
        public string batch { get; set; }
    }
}
