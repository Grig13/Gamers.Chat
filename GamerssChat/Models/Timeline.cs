﻿namespace GamerssChat.Models
{
    public class Timeline
    {
        public Guid Id { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}
