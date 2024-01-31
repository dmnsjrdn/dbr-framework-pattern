using OrderModule.Entities;
using MediatR;
using PatternsLibrary.Models;

namespace OrderModule.Features.Orders.v1
{
    public class OrderReadAllQuery : IRequest<ResultList<Order>>
    {
        public Order Model { get; set; }
    }
}