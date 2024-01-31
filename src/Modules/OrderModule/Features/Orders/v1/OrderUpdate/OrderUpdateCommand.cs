using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderUpdateCommand : IRequest<Result<Order>>
    {
        public Order Model { get; set; }
    }
}