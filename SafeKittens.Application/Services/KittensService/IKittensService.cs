using SafeKittens.Domain.Models;

namespace SafeKittens.Application.Services.KittensService
{
    public interface IKittensService
    {
        Task<List<Kitten>> GetKittens();

        Task<Kitten?> GetKitten(Guid kittenId);

        Task RegisterKitten(Kitten kitten);
    }
}
