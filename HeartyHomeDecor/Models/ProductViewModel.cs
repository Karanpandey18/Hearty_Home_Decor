using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        public string SKU { get; set; }

        [Required(ErrorMessage = "Please enter product name.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please select category.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Please select category")]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string ProductDetail { get; set; }

        public float Price { get; set; }

        public float Rating { get; set; }
    }
}
