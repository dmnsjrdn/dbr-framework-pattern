using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderCreateCommand : IRequest<Result<Order>>
    {
        public Order Model { get; set; }
    }
}