using System.ComponentModel.DataAnnotations;

namespace RusLabTest.Models
{
    public abstract class BaseModel<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }

    public abstract class BaseModel : BaseModel<Guid>
    {
        public BaseModel() => Id = Guid.NewGuid();
    }
}

