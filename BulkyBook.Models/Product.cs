using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1,10000)]

        // A list price of a book
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        // The admin can set different prices depending of the situation
        // The final price of a book
        public double Price{ get; set; }
        [Required]
        [Range(1, 10000)]
        // Price of a book if it's in bulk of 50
        public double Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        // Price of a book if it's in bulk of 50
        public double Price100 { get; set; }
        // The validateNever attribute = we dont want to validate that every time this property is populated, that is not the reason for adding a navigation property
        [ValidateNever]
        public string ImagerUrl {get; set; }
        [Required]
        // The entity framework will automatically create a foreign key relation with Category by calling the category class
        // If you not use the class name + Id together the foreign key relation will not happen automatically. You will have to use for example => [ForeignKey("CategoryTest")]
        public int CategoryId { get; set; }
        // The entity framework that this is a navigation property to the category class
        // The validateNever attribute = we dont want to validate that every time this property is populated, that is not the reason for adding a navigation property

        [ValidateNever]
        public Category Category { get; set; }
        [Required]
        // The entity framework will automatically create a foreign key relation with CoverType by calling the category class
        public int CoverTypeId { get; set; }
        // The entity framework that this is a navigation property to the CoverType class
        // The validateNever attribute = we dont want to validate that every time this property is populated, that is not the reason for adding a navigation property
        [ValidateNever]
        public CoverType CoverType { get; set; }
    }
}
