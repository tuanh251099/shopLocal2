using shopLocal.Application.Catalog.Products.Dtos;
using shopLocal.Application.Catalog.Products.Dtos.Manage;
using shopLocal.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace shopLocal.Application.Catalog.Products
{
    public interface IManagedProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(Dtos.Manage.ProductUpdateRequest request);
        Task<int> Delete( int productId);
        Task<bool> UpdatePrice(int ProductId, decimal newPrice);
        Task<bool> UpdateStock(int ProductId, int addedQuantity);
        Task AddViewcount(int ProductId);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
