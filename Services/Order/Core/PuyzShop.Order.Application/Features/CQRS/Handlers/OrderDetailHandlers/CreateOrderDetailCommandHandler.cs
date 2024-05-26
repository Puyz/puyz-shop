using PuyzShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                OrderingId = command.OrderingId,
                ProductAmount = command.ProductAmount,
                ProductId = command.ProductId,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductTotalPrice = command.ProductTotalPrice,
            });
        }
    }
}
