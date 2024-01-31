namespace OrderModule.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string UniqueId { get; set; }
        public Order Order { get; set; }
    }
}