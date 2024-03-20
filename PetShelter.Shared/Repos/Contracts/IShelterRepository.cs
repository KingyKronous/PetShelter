using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShelter.Shared.Dtos;

namespace PetShelter.Shared.Repos.Contracts
{
    public interface IShelterRepository : IBaseRepository<ShelterDto>
    {
    }
}
