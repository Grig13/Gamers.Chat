﻿namespace GamerssChat.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        public Product? Product { get; set; }
    }
}