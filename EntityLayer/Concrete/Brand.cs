using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        [StringLength(100)]
        public string BrandName { get; set; }
        public bool BrandStatus { get; set; }

        //public ICollection<Model> model { get; set; }
        //public int SubCategoryId { get; set; }
        //public virtual SubCategory SubCategory { get; set; }

    }
}
