using HW1WEB.Models;

namespace HW1WEB.Contracts.Requests
{
    public class CategoryCreateRequest
    {
            public string Name { get; set; }
            public string? Description { get; set; }


            public Category CategoryGetEntity()
            {
                return new Category {
                    Name = Name,
                    Description = Description
                };

            }
    }
}
