using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Services
{
    [AutoBind]
    public class UsersService : BaseCrudService<UserDto, IUserRepository>, IUsersService
    {
        public UsersService(IUserRepository repository) : base(repository)
        {

        }
    }
}
