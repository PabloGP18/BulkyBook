using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        // The validateNever attribute = we dont want to validate that every time this property is populated, that is not the reason for adding a navigation property
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        // The validateNever attribute = we dont want to validate that every time this property is populated, that is not the reason for adding a navigation property

        [ValidateNever]
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
        //IEnumerable<SelectListItem> is for a dropdown
        // this is how you can use projections with the .Select 

    }
}
