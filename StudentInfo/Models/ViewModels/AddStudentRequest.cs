namespace StudentInfo.Models.ViewModels
{
    public class AddStudentRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? session { get; set; }
    }
}
