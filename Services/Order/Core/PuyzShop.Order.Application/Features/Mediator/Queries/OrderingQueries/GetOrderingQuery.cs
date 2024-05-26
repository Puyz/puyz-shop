using MediatR;
using PuyzShop.Order.Application.Features.Mediator.Results.OrderingResults;

namespace PuyzShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}
