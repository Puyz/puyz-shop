using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PuyzShop.Order.Application.Features.Mediator.Commands.OrderingCommands;
using PuyzShop.Order.Application.Features.Mediator.Queries.OrderingQueries;
using PuyzShop.Order.Application.Features.Mediator.Results.OrderingResults;

namespace PuyzShop.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mediator.Send(new GetOrderingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _mediator.Send(new GetOrderingByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sipariş başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            await _mediator.Send(new RemoveOrderingCommand(id));
            return Ok("Sipariş başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOrderingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Sipariş başarıyla güncellendi");
        }
    }
}
