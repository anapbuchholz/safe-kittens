using SafeKittens.Domain;

namespace SafeKittens.Application.Repositories
{
    public interface IKittensRepository
    {
        Task<List<Kitten>> GetKittens();

        Task<Kitten?> GetKitten(Guid kittenId);

        Task RegisterKitten(Kitten kitten);
    }
}
