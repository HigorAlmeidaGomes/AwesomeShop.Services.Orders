using System;
using System.Threading;
using System.Threading.Tasks;
using AwesomeShop.Services.Orders.Core.Repositories;
using MediatR;

namespace AwesomeShop.Services.Orders.Application.Commands.Handlers
{
    public class DeleteOrderHandler : IRequestHandler<DeleteOrder, Unit>
    {
        private readonly IOrderRepository _orderRepository;

        public DeleteOrderHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        public async Task<Unit> Handle(DeleteOrder request, CancellationToken cancellationToken)
        {
            await _orderRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}