using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }

        public bool StoreStatus { get; set; }

        public ICollection<User> User { get; set; }
    }
}
