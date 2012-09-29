using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Le prénom est requis")]
        [DisplayName("Prénom")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [DisplayName("Nom")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "L'adresse est requise")]
        [DisplayName("Adresse")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "La ville est requise")]
        [DisplayName("Ville")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [DisplayName("Province")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Le code postal est requis")]
        [DisplayName("Code postal")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Le pays est requis")]
        [DisplayName("Pays")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Le téléphone est requis")]
        [DisplayName("Téléphone")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Le courriel est requis")]
        [DisplayName("Courriel")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Le courriel n'est pas valide")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
