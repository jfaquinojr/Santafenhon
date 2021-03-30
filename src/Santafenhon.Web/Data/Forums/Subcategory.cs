using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Santafenhon.Web.Data.Forums
{
    [Table("ForumSubcategories")]
    public class Subcategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid RowGuid { get; set; }
        public string Status { get; set; }
        public int ParentId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("ParentId")]
        public Subcategory Parent { get; set; }
    }
}
