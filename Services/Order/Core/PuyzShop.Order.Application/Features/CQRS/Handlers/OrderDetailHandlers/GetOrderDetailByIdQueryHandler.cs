using PuyzShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using PuyzShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var orderDetail = await _repository.GetByIdAsync(query.Id);

            return new GetOrderDetailByIdQueryResult
            {
                OrderDetailId = orderDetail.OrderDetailId,
                OrderingId = orderDetail.OrderingId,
                ProductId = orderDetail.ProductId,
                ProductAmount = orderDetail.ProductAmount,
                ProductName = orderDetail.ProductName,
                ProductPrice = orderDetail.ProductPrice,
                ProductTotalPrice = orderDetail.ProductTotalPrice
            };
        }
    }
}
