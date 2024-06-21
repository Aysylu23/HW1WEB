using HW1WEB.Models;

namespace HW1WEB.Contracts.Responses
{
    public class CategoryDeleteResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
       


        public CategoryDeleteResponse(Category categories)
        {
            Id = categories.Id;
            Name = categories.Name;
        }
    }
}

