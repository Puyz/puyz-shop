using PuyzShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderDetailCommand command)
        {
            var orderDetail = await _repository.GetByIdAsync(command.OrderDetailId);

            orderDetail.OrderingId = command.OrderingId;
            orderDetail.ProductId = command.ProductId;
            orderDetail.ProductName = command.ProductName;
            orderDetail.ProductPrice = command.ProductPrice;
            orderDetail.ProductTotalPrice = command.ProductTotalPrice;
            orderDetail.ProductAmount = command.ProductAmount;


            await _repository.UpdateAsync(orderDetail);
        }
    }
}
