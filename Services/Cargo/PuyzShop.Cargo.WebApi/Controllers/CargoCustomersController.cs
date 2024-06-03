using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuyzShop.Cargo.BusinessLayer.Abstract;
using PuyzShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using PuyzShop.Cargo.EntityLayer.Concrete;

namespace PuyzShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _customerService;

        public CargoCustomersController(ICargoCustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var values = _customerService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _customerService.TGetById(id);
            return Ok(values);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCargoCustomerDto createCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new()
            {
                Address = createCargoCustomerDto.Address,
                City = createCargoCustomerDto.City,
                District = createCargoCustomerDto.District,
                Email = createCargoCustomerDto.Email,
                Name = createCargoCustomerDto.Name,
                Surname = createCargoCustomerDto.Surname,
                Phone = createCargoCustomerDto.Phone
            };
            _customerService.TInsert(cargoCustomer);
            return Ok("Kargo müşteri eklendi");
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCargoCustomerDto updateCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new()
            {
                CargoCustomerId = updateCargoCustomerDto.CargoCustomerId,
                Address = updateCargoCustomerDto.Address,
                City = updateCargoCustomerDto.City,
                District = updateCargoCustomerDto.District,
                Email = updateCargoCustomerDto.Email,
                Name = updateCargoCustomerDto.Name,
                Surname = updateCargoCustomerDto.Surname,
                Phone = updateCargoCustomerDto.Phone
            };
            _customerService.TUpdate(cargoCustomer);
            return Ok("Kargo müşteri güncellendi");
        }

        [HttpDelete("remove")]
        public IActionResult Remove(int id)
        {
            _customerService.TDelete(id);
            return Ok("Kargo müşteri silindi");
        }


    }
}
