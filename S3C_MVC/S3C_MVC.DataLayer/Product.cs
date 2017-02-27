using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_MVC.DataLayer
{
   public class Product : EntityBase
    {
         [Required]
        [Display(Name ="عنوان")]
       [StringLength(10)]
        public String Title { get; set; }
        [Required]
        [Display(Name = "قیمت")]
        public int Price { get; set; }
        [Required]
        [Display(Name = "تعداد")]
        public int Count { get; set; }
        [Required]
        [Display(Name = "توضیحات")]
        public String Descrption { get; set; }
        [Display(Name = "عکس")]
        [Required]
        public String Image { get; set; }




    }
}
