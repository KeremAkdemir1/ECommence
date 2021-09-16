using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class Vegetable
    {
        [Key]
        public int VegetableId { get; set; }
        public string VegetableName { get; set; }
        public string VegetablePrice { get; set; }
        public string VegetablePhotoLink { get; set; }
        public virtual VegetableCategory Vegetables { get; set; }
    }
}
