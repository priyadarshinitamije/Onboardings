using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactOnboarding.Models
{
    public class SalesModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product id is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Customer id is required")]
        public int CustomerId { get; set; }
    }
}
