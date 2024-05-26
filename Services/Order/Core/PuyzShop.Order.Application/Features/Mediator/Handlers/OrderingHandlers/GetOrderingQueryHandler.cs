using MediatR;
using PuyzShop.Order.Application.Features.Mediator.Queries.OrderingQueries;
using PuyzShop.Order.Application.Features.Mediator.Results.OrderingResults;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingQueryHandler : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(o => new GetOrderingQueryResult
            {
                OrderingId = o.OrderingId,
                OrderDate = o.OrderDate,
                TotalPrice = o.TotalPrice,
                UserId = o.UserId,
            }).ToList();
        }
    }
}
