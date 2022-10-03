using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class ProductSubCategory
    {
        [Key]
        public int subCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
