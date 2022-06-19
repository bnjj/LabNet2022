using System.ComponentModel.DataAnnotations;

namespace Tp4.PracticaEF.MVC.Models
{
    public class ShippersView
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public string Phone { get; set; }
    }
}