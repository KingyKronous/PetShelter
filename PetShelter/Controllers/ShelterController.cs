using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter.ViewModels;
using System.Threading.Tasks;

namespace PetShelter.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class ShelterController : BaseCrudController<ShelterDto, IShelterRepository, ISheltersService, ShelterEditVM, ShelterDetailsVM>
    {
        ILocationsService _locationsService;
        //???? 

        protected override async Task<ShelterEditVM> PrePopulateVMAsync(ShelterEditVM editVM)
        {
            var editVm = new ShelterEditVM()
            {
                LocationsList = (await _locationsService.GetAllActiveAsync)
                .Select(x => new SelectListItem($"{x.Country}, {x.City}, {x.Address}", x.Id.ToString()))
            };

            return editVm;
        }
    }
}
