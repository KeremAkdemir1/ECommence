using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class VegetableCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string VegetableCategoryName { get; set; }
        public List<Vegetable> Category { get; set; }

    }
}
