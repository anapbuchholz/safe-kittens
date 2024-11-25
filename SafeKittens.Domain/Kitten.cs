namespace SafeKittens.Domain
{
    public class Kitten
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
    }
}
