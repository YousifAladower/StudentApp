namespace StudentApp.Modules.Dto
{
    public class StudentUpdateDto
    {
        public int Id { get; set; }
        public int SSN { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string emial { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string imagePath { get; set; }
    }
}
