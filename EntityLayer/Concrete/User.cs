using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string Uname { get; set; }
        [StringLength(100)]
        public string USurName { get; set; }
        [StringLength(100)]
        public string Usermage { get; set; }
        [StringLength(100)]
        public string UserMail { get; set; }
        [StringLength(11)]
        public string UserPhone { get; set; }
        public bool UserStatus { get; set; }
        public string UserPassword { get; set; }
        //public bool Admin { get; set; }
        public ICollection<Fixture> fixtures { get; set; }

        public int StoreID { get; set; }
        public virtual Store Store { get; set; }
    }
}