using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace AwesomeShop.Services.Orders.Application.Commands
{
    public class DeleteOrder : IRequest<Unit>
    {
       public DeleteOrder(Guid id)
        {
            Id = id;
        }
        
        public Guid Id { get; private set; }
    }
}