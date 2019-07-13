namespace MovieApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool UserExists(int id);
    }
}