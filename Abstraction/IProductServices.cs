using HW1WEB.Contracts.Requests;
using HW1WEB.Contracts.Responses;

namespace HW1WEB.Abstraction
{
    public interface IProductServices

    {
        public int AddProduct(ProductCreateRequest product);

        public IEnumerable<ProductResponse> GetProducts();
        public ProductResponse GetProductById(int id);
        public int DeleteProduct(ProductDeleteRequest product);
        public int DeleteProduct(int id);
        public string GetCsv(IEnumerable<ProductResponse> products);
        }
}
