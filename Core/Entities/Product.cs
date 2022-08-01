using Core.Contracts;

namespace Core.Entities
{
    public class Product : BaseEntity, IMustHaveTenant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public string TenantId { get; set; }

        public Product() { }

        public Product(string name, string description, int rate)
        {
            Name = name;
            Description = description;
            Rate = rate;
        }
    }
}
