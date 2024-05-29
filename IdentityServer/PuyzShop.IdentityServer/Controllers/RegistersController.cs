﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PuyzShop.IdentityServer.Dtos;
using PuyzShop.IdentityServer.Models;
using System.Threading.Tasks;

namespace PuyzShop.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(UserRegisterDto userRegisterDto)
        {
            var values = new ApplicationUser()
            {
                UserName = userRegisterDto.Username,
                Email = userRegisterDto.Email,
                Name = userRegisterDto.Name,
                Surname = userRegisterDto.Surname,
            };

            var result = await _userManager.CreateAsync(values, userRegisterDto.Password);

            if (result.Succeeded)
            {
                return Ok("Kullanıcı başarılı şekilde eklendi");
            }
            return BadRequest("Hata oluştu");

        }
    }
}
