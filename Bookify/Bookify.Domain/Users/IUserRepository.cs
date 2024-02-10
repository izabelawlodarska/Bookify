namespace Bookify.Domain.Users
{
    public interface IUserRepository
    {
        Task<User> GetByIfAsync(Guid id, CancellationToken cancellationToken = default);

        void Add(User user);
    }
}
