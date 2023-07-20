using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }

        [StringLength(100)]
        public string SubCategoryName { get; set; }
        public string SubCategoryDescription { get; set; }

        public bool SubCategoryStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Fixture> fixtures { get; set; }

        //public ICollection<Brand> brand { get; set; }
    }
}
