using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FixtureModel
    {
        [Key]
        public int FixtureModelId { get; set; }
        [StringLength(100)]
        public string FixtureModelName { get; set; }

        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }
        public bool FixtureModelStatus { get; set; }
    }
}
