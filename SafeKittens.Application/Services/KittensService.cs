using SafeKittens.Application.Repositories;
using SafeKittens.Domain;

namespace SafeKittens.Application.Services
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
