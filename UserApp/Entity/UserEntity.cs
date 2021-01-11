using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Entity
{
    public class UserEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GitHubAccountUrl { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
