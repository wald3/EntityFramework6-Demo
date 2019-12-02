namespace DemoDb.DAL.Models
{
    abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreateAt { get; set; }
        public virtual Address Address { get; set; }
    }
}
