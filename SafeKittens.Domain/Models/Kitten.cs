namespace SafeKittens.Domain.Models
{
    public class Kitten
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public bool IsSpayed { get; set; }
    }
}
