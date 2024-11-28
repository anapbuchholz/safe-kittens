using SafeKittens.Domain.Models;

namespace SafeKittens.Controllers.Kittens.Contracts
{
    public class KittenResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public bool IsSpayed { get; set; }
    }
}
