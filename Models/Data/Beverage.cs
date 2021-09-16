using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class Beverage
    {
        [Key]
        public int BeverageId { get; set; }
        public string BeverageName { get; set; }
        public string BeveragePrice { get; set; }
        public string BeveragePhotoLink { get; set; }
        public bool Alcohol { get; set; }

        public virtual BeverageCategory Beverages { get; set; }
    }
}
