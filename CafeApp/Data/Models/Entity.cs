using System.ComponentModel.DataAnnotations;

namespace CafeApp.Data.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
