using CafeApp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DIPLOM.Data.DB.Models
{
    public class Role : Entity
    {
        public string? UserRole { get; set; }
        public string? UserPassword { get; set; }
    }
}