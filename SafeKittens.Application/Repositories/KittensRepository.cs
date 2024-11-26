using SafeKittens.Domain;

namespace SafeKittens.Application.Repositories
{
    public class KittensRepository : IKittensRepository
    {
        private readonly Dictionary<Guid, Kitten> _database;

        public KittensRepository()
        {
            _database = new Dictionary<Guid, Kitten>();
        }

        public async Task<List<Kitten>> GetKittens()
        {
            return [.. _database.Values];
        }

        public async Task<Kitten?> GetKitten(Guid kittenId)
        {
            return _database.TryGetValue(kittenId, out var kitten) ? kitten : null;
        }

        public async Task RegisterKitten(Kitten kitten)
        {
            _database.Add(kitten.Id, kitten);
            await Task.CompletedTask;
        }
    }
}
