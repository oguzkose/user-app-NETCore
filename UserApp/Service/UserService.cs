using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Context;
using UserApp.Entity;

namespace UserApp.Service
{
    public class UserService
    {
        private readonly UserContext _userContext;
        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public void Add(UserEntity entity)
        {
            _userContext.Users.Add(entity);
        }

        public List<UserEntity> GetAllUsers()
        {
            return _userContext.Users;
        }
        public UserEntity GetUser(int id)
        {
            return _userContext.Users.FirstOrDefault(x => x.Id == id);
        }
        public void Edit(UserEntity entity)
        {
            var currentEntity = _userContext.Users.FirstOrDefault(x => x.Id == entity.Id);
            _userContext.Users.Remove(currentEntity);
            _userContext.Users.Add(entity);
        }
        public List<UserEntity> Query(int id, string name, string surname)
        {
            return _userContext.Users.Where(x => x.Id == id ||
                                                 x.Name == name ||
                                                 x.Surname == surname).ToList();
        }

    }
}
