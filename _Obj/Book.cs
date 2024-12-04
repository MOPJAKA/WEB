namespace WEB._Obj
{
    public class Book
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

        public string? Edition { get; set; }

        public int PublicationYear { get; set; }

        public string? ShelfLocation { get; set; }

        public string? Status { get; set; }
    }
}
