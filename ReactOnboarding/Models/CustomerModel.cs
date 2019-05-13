using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactOnboarding.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomersId { get; set; }

        [DisplayName("Customers Name")]
        [Required(ErrorMessage = "Customers Name is Required")]
        [StringLength(40, MinimumLength = 3)]
        public string CustomersName { get; set; }

        [Required(ErrorMessage = "Customers Address is required")]
        [StringLength(85)]
        public string CustomersAddress { get; set; }

        public ICollection<ProductSold> Sales { get; set; }
    }
}
