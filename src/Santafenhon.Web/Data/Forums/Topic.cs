using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Santafenhon.Web.Data.Forums
{
    [Table("ForumTopics")]
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid RowGuid { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public string Status { get; set; }
        public int SubcategoryId { get; set; }

        [ForeignKey("SubcategoryId")]
        public Subcategory Subcategory { get; set; }

        public List<Post> Posts { get; set; }
    }
}
