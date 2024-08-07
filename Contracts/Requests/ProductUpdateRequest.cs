﻿using HW1WEB.Models;

namespace HW1WEB.Contracts.Requests
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public int? CategoryId { get; set; }

        public Product ProductGetEntity()
        {
            return new Product
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Price = Price,
                CategoryId = CategoryId
            };
        }
    }
}
