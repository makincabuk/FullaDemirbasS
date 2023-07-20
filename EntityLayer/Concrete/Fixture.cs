using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Fixture
    {
        [Key]
        public int FixtureId { get; set; }
        [StringLength(100)]
        public string FixtureName { get; set; }
        [StringLength(100)]
        public string FixtureSeriNo { get; set; }
        [StringLength(100)]
        public string FixtureModelNo { get; set; }
        [StringLength(100)]
        public string FixtureImei1 { get; set; }
        [StringLength(100)]
        public string FixtureImei2 { get; set; }
        [StringLength(100)]
        public string FixtureMac1 { get; set; }
        [StringLength(100)]
        public string FixtureMac2 { get; set; }
        [StringLength(1000)]
        public string FixtureDescription { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public bool UserStatus { get; set; }
    }
}
