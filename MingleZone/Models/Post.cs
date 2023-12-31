﻿using Microsoft.Extensions.Hosting;
using MingleZone.Utils;
using System.Net.Mail;

namespace MingleZone.Models
{
    public class Post
    {
        public int Id { get; set; }
        [SwaggerSchemaExample("it's a good day")]
        public string Content { get; set; } = null!;
        public int UserId { get; set; }
        public int CommunityId { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual User? User { get; set; } = null!;
        public virtual Community? Community { get; set; } = null!;
        public virtual ICollection<PostTag> Tags { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public Post()
        {
            Tags = new HashSet<PostTag>();
            Attachments = new HashSet<Attachment>();
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
