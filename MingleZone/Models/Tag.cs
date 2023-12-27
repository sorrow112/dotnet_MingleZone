﻿namespace MingleZone.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Post> Posts { get; set; }
        public DateTime CreatedDate { get; set; }
        public Tag()
        {
            CreatedDate = DateTime.Now;
            Posts = new HashSet<Post>();
        }
    }
}
