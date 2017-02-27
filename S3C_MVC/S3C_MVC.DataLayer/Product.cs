using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_MVC.DataLayer
{
   public class Product
    {
        public int ID { get; set; }

        public String Title { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        public String Descrption { get; set; }

        public DateTime RegisterDate { get; set; }


    }
}
