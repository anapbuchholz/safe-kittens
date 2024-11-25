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

        public Kitten GetKitten()
        {
            return _kittensRepository.GetKitten();
        }
    }
}
