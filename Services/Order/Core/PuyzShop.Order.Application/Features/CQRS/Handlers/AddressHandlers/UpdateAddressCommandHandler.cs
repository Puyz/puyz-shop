using PuyzShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand updateAddressCommand)
        {
            var address = await _repository.GetByIdAsync(updateAddressCommand.AddressId);

            address.Detail = updateAddressCommand.Detail;
            address.City = updateAddressCommand.City;
            address.District = updateAddressCommand.District;
            address.UserId = updateAddressCommand.UserId;
            await _repository.UpdateAsync(address);
        }
    }
}
