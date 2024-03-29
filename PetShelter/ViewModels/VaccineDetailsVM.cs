using PetShelter.Shared.Dtos;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class VaccineDetailsVM : BaseVM
    {
        public VaccineDetailsVM()
        {
            this.PetVaccines = new List<PetVaccineDetailsVM>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<PetVaccineDetailsVM> PetVaccines { get; set; }
    }
}
