using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFormsDemo.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters.")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PublishedDate { get; set; }
    } 
}
