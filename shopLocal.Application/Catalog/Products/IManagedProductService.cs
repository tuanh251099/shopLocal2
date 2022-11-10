using shopLocal.Application.Catalog.Products.Dtos;

namespace shopLocal.Application.Catalog.Products
{
    public interface IManagedProductService
    {
        int Create(ProductCreateRequest request);
        Task<int> Delete(int productId);
        Task<List<ProductViewModel>> GetAll();
    }
}