using Microsoft.AspNetCore.Mvc;
using PuyzShop.Cargo.BusinessLayer.Abstract;
using PuyzShop.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using PuyzShop.Cargo.EntityLayer.Concrete;

namespace PuyzShop.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _cargoOperationService;

        public CargoOperationsController(ICargoOperationService CargoOperationService)
        {
            _cargoOperationService = CargoOperationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var values = _cargoOperationService.TGetAll();
            return Ok(values);
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCargoOperationDto createCargoOperationDto)
        {
            CargoOperation CargoOperation = new()
            {
                Barcode = createCargoOperationDto.Barcode,
                Description = createCargoOperationDto.Description,
                OperationDate = createCargoOperationDto.OperationDate,
            };
            _cargoOperationService.TInsert(CargoOperation);
            return Ok("Kargo işlemi oluşturuldu");
        }

        [HttpDelete("remove")]
        public IActionResult Remove(int id)
        {
            _cargoOperationService.TDelete(id);
            return Ok("Kargo işlemi silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _cargoOperationService.TGetById(id);
            return Ok(values);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCargoOperationDto updateCargoOperationDto)
        {
            CargoOperation CargoOperation = new()
            {
                CargoOperationId = updateCargoOperationDto.CargoOperationId,
                Barcode = updateCargoOperationDto.Barcode,
                Description = updateCargoOperationDto.Description,
                OperationDate = updateCargoOperationDto.OperationDate,
            };
            _cargoOperationService.TUpdate(CargoOperation);
            return Ok("Kargo işlemi güncellendi");
        }
    }
}
