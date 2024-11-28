using SafeKittens.Application.Repositories.GodparentsRepository;

namespace SafeKittens.Application.Services.GodparentsService
{
    public sealed class GodparentsService : IGodparentsService
    {
        private readonly IGodparentsRepository _godparentsRepository;

        public GodparentsService(IGodparentsRepository godparentsRepository)
        {
            _godparentsRepository = godparentsRepository;
        }
    }
}
