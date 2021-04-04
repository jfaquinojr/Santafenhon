using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Santafenhon.Web.Data.Forums
{
    [Table("ForumPosts")]
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public int TopicId { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }
        [Required]
        public Guid RowGuid { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        [Required]
        public string Message { get; set; }

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; }

    }
}
