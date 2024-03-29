using PetShelter.Shared.Dtos;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class ShelterDetailsVM : BaseVM
    {
        public ShelterDetailsVM()
        {
            this.Pets = new List<PetDetailsVM>();
            this.Employees = new List<UserDetailsVM>();
        }

        public int PetCapacity { get; set; }

        public int LocationId { get; set; }

        public LocationDetailsVM Location { get; set; }

        public List<UserDetailsVM> Employees { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
    }
}
