﻿namespace Oranges_ASPNet.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Product> Products { get; set; }
    }
}
