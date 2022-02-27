using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class CategoryMaster
    {
        [Key]
        public int catId { get; set; }
        public string catName { get; set; }
        public string catOrder { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
    }
}
