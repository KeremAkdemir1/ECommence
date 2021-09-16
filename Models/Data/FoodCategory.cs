using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class FoodCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string FoodCategoryName { get; set; }
        public List<Food> Food { get; set; }
    }
}
