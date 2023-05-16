using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Allergen : Entity
    {
        public string? Name { get; set; }

        public virtual List<Ingridient> Ingridients { get; set; }
    }
}