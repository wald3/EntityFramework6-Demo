namespace DemoDb.DAL.Models
{
    class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Quentity { get; set; }
        public System.DateTime CreateAt { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
