using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Shared.Services.Contracts;
using PetShelter.ViewModels;
using System.Threading.Tasks;

namespace PetShelter.Controllers
{
    public class ShelterController : Controller
    {
        ILocationsService _locationsService;
        //???? 

        protected override async Task<ShelterEditVM> PrePopulateVMAsync()
        {
            var editVm = new ShelterEditVM()
            {
                LocationsList = (await _locationsService.GetAllActiveAsync())
                .Select(x => new SelectListItem($"{x.Country}, {x.City}, {x.Address}", x.Id.ToString()))
            };

            return editVm;
        }
    }
}
