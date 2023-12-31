﻿using MingleZone.Utils;

namespace MingleZone.Models
{
    public class Community
    {
        public int Id { get; set; }
        [SwaggerSchemaExample("Bugs generators")]
        public string Name { get; set; } = null!;
        [SwaggerSchemaExample("feel free to join if you suck at coding")]
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int AdminId { get; set; }
        public virtual User? Admin { get; set; }
        public virtual ICollection<MembershipRequest> Requests { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<CommunityMembership> Memberships { get; set; }

        public Community()
        {
            CreatedDate = DateTime.Now;
            Posts = new HashSet<Post>();
            Requests = new HashSet<MembershipRequest>();
            Memberships = new HashSet<CommunityMembership>();
            UpdatedDate = DateTime.Now;
        }
    }
}
