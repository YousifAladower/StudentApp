using System.ComponentModel.DataAnnotations;

namespace StudentApp.Modules.Dto
{
    public class StudentAddDto
    {
        [Required(ErrorMessage = "this filed is required")]
        public int SSN { get; set; }
        [Required(ErrorMessage = "this filed is required")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "this filed is required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "this filed is required")]
        public string emial { get; set; }
        [Required(ErrorMessage = "this filed is required")]
        public string password { get; set; }
        [Required(ErrorMessage = "this filed is required")]
        public int phone { get; set; }
        [Required(ErrorMessage = "this filed is required")]
        public string imagePath { get; set; }
    }
}
