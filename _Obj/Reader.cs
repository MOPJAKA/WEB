namespace WEB._Obj
{
    public class Reader
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? Gender { get; set; } // "M" or "F"
        public string? EducationLevel { get; set; }
        public string? Status { get; set; } // "Active" or "Inactive"
    }
}
