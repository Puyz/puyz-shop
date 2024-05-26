using PuyzShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderDetailCommand command)
        {
            var orderDetail = await _repository.GetByIdAsync(command.Id);

            await _repository.DeleteAsync(orderDetail);
        }
    }
}
