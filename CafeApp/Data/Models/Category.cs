using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Category : Entity
    {
        public string? CategoryName { get; set; }
    }
}