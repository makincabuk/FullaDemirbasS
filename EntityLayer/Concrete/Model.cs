using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        [StringLength(100)]
        public string ModelName { get; set; }

        public bool ModelStatus { get; set; }
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
