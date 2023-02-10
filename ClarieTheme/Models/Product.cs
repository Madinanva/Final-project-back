using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClarieTheme.Models
{
    public class Product : BaseEntity
    {
        [StringLength(800)]
        public string Image { get; set; }
        [StringLength(800)]
        public string Title { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
    }
}

