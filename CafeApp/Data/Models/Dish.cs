using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Dish : Entity
    {
        public string? DishName { get; set; }
        public string? Info { get; set; }
        public decimal Price { get; set; }
        public string? DishImage { get; set; }
        public virtual Category? Category { get; set; }
        public virtual List<Ingridient> Ingridients { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}