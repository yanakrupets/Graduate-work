using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Ingridient : Entity
    {
        public string? Name { get; set; }

        public virtual List<Allergen> Allergens { get; set; }

        public virtual List<Dish> Dishes { get; set; }
    }
}