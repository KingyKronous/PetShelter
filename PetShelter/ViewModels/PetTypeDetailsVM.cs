using PetShelter.Shared.Dtos;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class PetTypeDetailsVM : BaseVM
    {
        public PetTypeDetailsVM()
        {
            this.Pets = new List<PetDetailsVM>();
        }

        public string Name { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
    }
}
