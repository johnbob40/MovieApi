using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Repositories.InMemory.DataSources
{
    public static class Users
    {
        public static List<User> UserList;

        static Users()
        {
            UserList = new List<User> {
                new User {Id = 1},
                new User {Id = 2},
                new User {Id = 3},
                new User {Id = 4},
                new User {Id = 5},
                new User {Id = 6},
            };
        }
    }
}