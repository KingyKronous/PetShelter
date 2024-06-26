﻿using PetShelter.Shared.Dtos;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class PetDetailsVM : BaseVM
    {
        public PetDetailsVM()
        {
            this.PetVaccines = new List<PetVaccineDetailsVM>();
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAdopted { get; set; }

        public bool IsEuthanized { get; set; }

        public int PetTypeId { get; set; }

        public PetTypeDetailsVM PetType { get; set; }

        public int BreedId { get; set; }

        public BreedDetailsVM Breed { get; set; }

        public int? AdopterId { get; set; }

        public UserDetailsVM Adopter { get; set; }

        public int? GiverId { get; set; }

        public UserDetailsVM Giver { get; set; }

        public int? ShelterId { get; set; }

        public ShelterDetailsVM Shelter { get; set; }

        public List<PetVaccineDetailsVM> PetVaccines { get; set; }
    }
}
