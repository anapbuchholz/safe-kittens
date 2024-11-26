using SafeKittens.Domain;

namespace SafeKittens.Application.Services
{
    public interface IKittensService
    {
        Task<List<Kitten>> GetKittens();

        Task<Kitten?> GetKitten(Guid kittenId);

        Task RegisterKitten(Kitten kitten);
    }
}
