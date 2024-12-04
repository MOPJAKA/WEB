namespace WEB._Obj
{
    public class BookLending
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public DateOnly LendingDate { get; set; }
        public DateOnly ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
    }
}
