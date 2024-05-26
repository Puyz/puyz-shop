using MediatR;
using PuyzShop.Order.Application.Features.Mediator.Results.OrderingResults;

namespace PuyzShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult> // geri dönüş tipi
    {
        public int Id { get; set; }

        public GetOrderingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
