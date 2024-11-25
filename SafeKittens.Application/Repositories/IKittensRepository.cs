using SafeKittens.Domain;

namespace SafeKittens.Application.Repositories
{
    public interface IKittensRepository
    {
        Kitten GetKitten();
    }
}
