using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Models;

namespace OrderModule.Features.OrderItems.v1
{
    public class OrderItemReadAllQuery : IRequest<ResultList<OrderItem>>
    {
        public OrderItem Model { get; set; }
    }
}