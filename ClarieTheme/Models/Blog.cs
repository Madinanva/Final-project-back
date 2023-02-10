using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClarieTheme.Models
{
    public class Blog : BaseEntity
    {
        [StringLength(800)]
        public string Image { get; set; }
        [StringLength(100)]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int Comment { get; set; }
        [StringLength(800)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
}

