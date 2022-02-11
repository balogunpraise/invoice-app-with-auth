using System.ComponentModel.DataAnnotations;

namespace AspNetCoreInvoice.Web.Models
{

    public class Item 
    {
       
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Units/Hours is required")]
        public int Units { get; set; }

        [Required(ErrorMessage = "Price Per Unit/Hour is required")]
        public double PricePerUnit { get; set; }

        public double TotalCost => Units * PricePerUnit;
    }
}