

namespace BurgerTimeApp.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelievered { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Location { get; set; }

        public Order(int id, string fullName, string address, bool isDelievered, List<Burger> burgers, string location)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            IsDelievered = isDelievered;
            Burgers = burgers;
            Location = location;
        }

        public Order()
        {

        }
    }
}
