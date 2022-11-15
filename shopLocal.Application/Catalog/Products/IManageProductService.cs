using Microsoft.AspNetCore.Http;
using shopLocal.ViewModels.Catalog.Products;
using shopLocal.ViewModels.Catalog.Products.Manage;
using shopLocal.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete( int productId);
        Task<ProductViewModel> GetById( int productId); 
        Task<bool> UpdatePrice(int ProductId, decimal newPrice);
        Task<bool> UpdateStock(int ProductId, int addedQuantity);
        Task AddViewcount(int ProductId);
        //Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId );
        Task<int> UpdateImages(int imageId, string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
