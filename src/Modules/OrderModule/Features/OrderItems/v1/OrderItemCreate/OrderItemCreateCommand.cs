using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Models;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemCreateCommand : IRequest<Result<OrderItem>>
    {
        public OrderItem Model { get; set; }
    }
}