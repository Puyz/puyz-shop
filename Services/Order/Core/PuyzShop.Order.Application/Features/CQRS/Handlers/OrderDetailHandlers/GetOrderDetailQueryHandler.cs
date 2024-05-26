using PuyzShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var details = await _repository.GetAllAsync();
            return details.Select(orderDetail => new GetOrderDetailQueryResult
            {
                OrderDetailId = orderDetail.OrderDetailId,
                OrderingId = orderDetail.OrderingId,
                ProductId = orderDetail.ProductId,
                ProductAmount = orderDetail.ProductAmount,
                ProductName = orderDetail.ProductName,
                ProductPrice = orderDetail.ProductPrice,
                ProductTotalPrice = orderDetail.ProductTotalPrice
            }).ToList();
        }
    }
}
