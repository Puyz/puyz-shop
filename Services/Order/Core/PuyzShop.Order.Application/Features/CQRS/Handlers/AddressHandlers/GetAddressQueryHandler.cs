using PuyzShop.Order.Application.Features.CQRS.Results.AddressResults;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var addresses = await _repository.GetAllAsync();
            return addresses.Select(a => new GetAddressQueryResult
            {
                AddressId = a.AddressId,
                City = a.City,
                Detail = a.Detail,
                District = a.District,
                UserId = a.UserId
            }).ToList();
        }
    }
}
