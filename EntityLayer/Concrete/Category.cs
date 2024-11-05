using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategorName { get; set; } 
        [StringLength(200)]
        public string CategorDescription { get; set; }
        public bool CategoryStatus { get; set; }
        
        public ICollection<Heading> headings { get; set; }
    }
}
 