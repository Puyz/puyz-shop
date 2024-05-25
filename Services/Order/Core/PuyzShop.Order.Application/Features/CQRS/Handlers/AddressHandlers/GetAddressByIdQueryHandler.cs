using PuyzShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using PuyzShop.Order.Application.Features.CQRS.Results.AddressResults;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
        {
            var address = await _repository.GetByIdAsync(query.Id);
            return new GetAddressByIdQueryResult
            {
                AddressId = address.AddressId,
                City = address.City,
                Detail = address.Detail,
                District = address.District,
                UserId = address.UserId
            };
        }
    }
}
