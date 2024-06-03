using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuyzShop.Cargo.BusinessLayer.Abstract;
using PuyzShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using PuyzShop.Cargo.EntityLayer.Concrete;

namespace PuyzShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var values = _cargoDetailService.TGetAll();
            return Ok(values);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail CargoDetail = new()
            {
                CargoCompanyId = createCargoDetailDto.CargoCompanyId,
                Barcode = createCargoDetailDto.Barcode,
                ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
                SenderCustomer = createCargoDetailDto.SenderCustomer
            };
            _cargoDetailService.TInsert(CargoDetail);
            return Ok("Kargo detayı oluşturuldu");
        }

        [HttpDelete("remove")]
        public IActionResult Remove(int id)
        {
            _cargoDetailService.TDelete(id);
            return Ok("Kargo detayı silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _cargoDetailService.TGetById(id);
            return Ok(values);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail CargoDetail = new()
            {
                CargoDetailId = updateCargoDetailDto.CargoDetailId,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId,
                Barcode = updateCargoDetailDto.Barcode,
                ReceiverCustomer = updateCargoDetailDto.ReceiverCustomer,
                SenderCustomer = updateCargoDetailDto.SenderCustomer
            };
            _cargoDetailService.TUpdate(CargoDetail);
            return Ok("Kargo detayı güncellendi");
        }
    }
}
