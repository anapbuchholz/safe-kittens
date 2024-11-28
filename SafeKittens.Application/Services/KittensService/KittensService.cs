using SafeKittens.Application.Repositories.KittensRepository;
using SafeKittens.Domain.Models;

namespace SafeKittens.Application.Services.KittensService
{
    sealed public class KittensService : IKittensService
    {
        private readonly IKittensRepository _kittensRepository;

        public KittensService(IKittensRepository kittensRepository)
        {
            _kittensRepository = kittensRepository;
        }

        public async Task<List<Kitten>> GetKittens()
        {
            return await _kittensRepository.GetKittens();
        }

        public async Task<Kitten?> GetKitten(Guid kittenId)
        {
            return await _kittensRepository.GetKitten(kittenId);
        }

        public async Task RegisterKitten(Kitten kitten)
        {
            await _kittensRepository.RegisterKitten(kitten);
        }
    }
}
