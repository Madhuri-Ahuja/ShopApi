using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Models
{
    public class ProductInfo
    {
        [Key]
        public int productId { get; set; }
        public string productBrand { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public string productDetails { get; set; }       
        public string productImage { get; set; }
        public decimal productQuantity { get; set; }
        public bool addedToWishList { get; set; }
        public DateTime? productExpiryDate { get; set; }

        [Display(Name ="Category Type")]

        public int categoryId { get; set; }

        [ForeignKey("categoryId")]
        public virtual ProductCategory productCategory { get; set; }

        [Display(Name ="SubCategory Type")]
        public int subCategoryId { get; set; }
        [ForeignKey("subCategoryId")]
        public virtual ProductSubCategory productSubCategory { get; set; }
    }
}
