using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CategoryMasterModel
    {
        public int catId { get; set; }
        public string catName { get; set; }
        public string catOrder { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
    }
}
