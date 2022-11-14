using shopLocal.ViewModels.Catalog.Products;
using shopLocal.ViewModels.Catalog.Products.Public;
using shopLocal.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>>  GetAllByCategoryId(GetProductPagingRequest request);
    }
}
