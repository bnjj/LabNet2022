using System.ComponentModel.DataAnnotations;

namespace Tp4.PracticaEF.MVC.Models
{
    public class ShippersView
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "No puede guardar un Shipper vacio.")]
        [StringLength(40,ErrorMessage = "El campo Empresa no puede tener mas de {1} caracteres")]
        public string CompanyName { get; set; }

        [StringLength(24, ErrorMessage = "El campo Telefono no puede tener mas de {1} caracteres")]
        public string Phone { get; set; }
    }
}