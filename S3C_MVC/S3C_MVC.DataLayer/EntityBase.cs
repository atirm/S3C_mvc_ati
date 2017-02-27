using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_MVC.DataLayer
{
  public abstract  class EntityBase
    {  public EntityBase()
        {
            RegisterDate = DateTime.Now;
        }
        public int ID { get; set; }
        [Display(Name = "تاریخ")]
        public DateTime RegisterDate { get; set; }
    }
}
