using SafeKittens.Domain.Models;

namespace SafeKittens.Application.Repositories.KittensRepository
{
    public interface IKittensRepository
    {
        Task<List<Kitten>> GetKittens();

        Task<Kitten?> GetKitten(Guid kittenId);

        Task RegisterKitten(Kitten kitten);
    }
}
