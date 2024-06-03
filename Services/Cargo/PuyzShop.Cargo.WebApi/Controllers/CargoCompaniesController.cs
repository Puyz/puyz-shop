using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuyzShop.Cargo.BusinessLayer.Abstract;
using PuyzShop.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using PuyzShop.Cargo.EntityLayer.Concrete;

namespace PuyzShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompaniesController : ControllerBase
    {
        private readonly ICargoCompanyService _companyService;

        public CargoCompaniesController(ICargoCompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var values = _companyService.TGetAll();
            return Ok(values);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCargoCompanyDto createCargoCompanyDto)
        {
            CargoCompany cargoCompany = new()
            {
                CargoCompanyName = createCargoCompanyDto.CargoCompanyName
            };
            _companyService.TInsert(cargoCompany);
            return Ok("Kargo şirketi oluşturuldu");
        }

        [HttpDelete("remove")]
        public IActionResult Remove(int id)
        {
            _companyService.TDelete(id);
            return Ok("Kargo şirketi silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _companyService.TGetById(id);
            return Ok(values);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            CargoCompany cargoCompany = new()
            {
                CargoCompanyId = updateCargoCompanyDto.CargoCompanyId,
                CargoCompanyName = updateCargoCompanyDto.CargoCompanyName
            };
            _companyService.TUpdate(cargoCompany);
            return Ok("Kargo şirketi güncellendi");
        }
    }
}
