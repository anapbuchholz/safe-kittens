using SafeKittens.Domain;

namespace SafeKittens.Application.Repositories
{
    public class KittensRepository : IKittensRepository
    {
        public Kitten GetKitten()
        {
            var kitten = new Kitten()
            {
                Age = "2",
                Description = "purrfect",
                Gender = Gender.Male,
                Name = "Theo",
                Id = Guid.NewGuid()
            };

            return kitten;
        }
    }
}
