using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Models.Data
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Writer { get; set; }
        public string Writing { get; set; }
    }
}
