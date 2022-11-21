using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeartyHomeDecor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string ProductName { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set;}
        public string ProductDetail { get; set; }
        public float Price { get; set; }
        public float Rating { get; set; }
    }
}
