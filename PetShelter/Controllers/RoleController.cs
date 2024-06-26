﻿using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter.ViewModels;

namespace PetShelter.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class RoleController : BaseCrudController<RoleDto, IRoleRepository, IRolesService, RoleEditVM, RoleDetailsVM>
    {
        public RoleController(IRolesService service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
