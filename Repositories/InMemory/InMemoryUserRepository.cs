using MovieApi.Repositories.InMemory.DataSources;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories.InMemory
{
    public class InMemoryUserRepository : IUserRepository
    {
        public bool UserExists(int id)
        {
            return Users.UserList.Exists(u => u.Id == id);
        }
    }
}