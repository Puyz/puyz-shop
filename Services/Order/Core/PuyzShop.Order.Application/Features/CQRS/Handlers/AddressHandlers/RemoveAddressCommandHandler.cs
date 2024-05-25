using PuyzShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using PuyzShop.Order.Application.Interfaces;
using PuyzShop.Order.Domain.Entities;

namespace PuyzShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommand removeAddressCommand)
        {
            var address = await _repository.GetByIdAsync(removeAddressCommand.Id);
            await _repository.DeleteAsync(address);
        }
    }
}
