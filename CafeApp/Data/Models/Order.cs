using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Order : Entity
    {

        public DateTime Date { get; set; }

        public double Price { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public virtual List<Dish> Dishes { get; set; }
    }
}
