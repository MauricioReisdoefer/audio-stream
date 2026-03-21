namespace backend.Domain.Entities
{
    public class Music
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Artist { get; set; }
        public required string Url { get; set; }
        public DateTime UploadedAt { get; set; }
        public required IFormFile File { get; set; }
    }
}
