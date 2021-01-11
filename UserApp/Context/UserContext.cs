using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Entity;

namespace UserApp.Context
{
    public class UserContext
    {
        public List<UserEntity> Users { get; set; }
        public UserContext()
        {
            Users = new List<UserEntity>
            {
                new UserEntity
                {
                    Id=1,
                    Name="Oğuz",
                    Surname="Köse",
                    Gender="Erkek",
                    BirthDate= new DateTime(1992,4,21),
                    Email="oguz_kose275@hotmail.com",
                    GitHubAccountUrl="https://github.com/oguzkose"
                },
                new UserEntity
                {
                    Id=2,
                    Name="John",
                    Surname="Doe",
                    Gender="Erkek",
                    BirthDate= new DateTime(1990,1,1),
                    Email="johnDoe@gmail.com",
                    GitHubAccountUrl="https://github.com/johndoe222"
                },
                new UserEntity
                {
                    Id=3,
                    Name="Jane",
                    Surname="Walker",
                    Gender="Kadın",
                    BirthDate= new DateTime(1980,3,12),
                    Email="janeWalker@gmail.com",
                    GitHubAccountUrl="https://github.com/janeWalker222"
                }
            };
        }
    }
}
