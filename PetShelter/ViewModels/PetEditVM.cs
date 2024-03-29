using PetShelter.Shared.Dtos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class PetEditVM : BaseVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public bool IsAdopted { get; set; }
        [Required]
        public bool IsEuthanized { get; set; }
        [Required]
        public int PetTypeId { get; set; }
        [Required]
        public PetTypeDetailsVM PetType { get; set; }
        [Required]
        public int BreedId { get; set; }
        [Required]
        public BreedDetailsVM Breed { get; set; }
        [Required]
        public UserDetailsVM Adopter { get; set; }
        [Required]
        public UserDetailsVM Giver { get; set; }
        [Required]
        public ShelterDetailsVM Shelter { get; set; }
    }
}
