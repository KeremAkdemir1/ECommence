using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodPrice { get; set; }
        public int CategoryID { get; set; }
        public string FoodPhotoLink { get; set; }
        public virtual FoodCategory Category { get; set; }
    }
}
