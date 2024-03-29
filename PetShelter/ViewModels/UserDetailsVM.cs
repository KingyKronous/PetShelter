using PetShelter.Shared.Dtos;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class UserDetailsVM : BaseVM
    {
        public UserDetailsVM()
        {
            this.AdoptedPets = new List<PetDetailsVM>();
            this.GivenPets = new List<PetDetailsVM>();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? RoleId { get; set; }

        public RoleDetailsVM Role { get; set; }

        public int? ShelterId { get; set; }

        public ShelterDetailsVM Shelter { get; set; }

        public List<PetDetailsVM> AdoptedPets { get; set; }

        public List<PetDetailsVM> GivenPets { get; set; }
    }
}
