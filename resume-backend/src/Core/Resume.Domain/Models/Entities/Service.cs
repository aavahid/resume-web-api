using Resume.Infrastructure.Concrates;

namespace Resume.Domain.Models.Entities
{
    public class Service : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
