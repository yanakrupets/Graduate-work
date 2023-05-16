using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Booking : Entity
    {
        public string? CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Date { get; set; }
    }
}