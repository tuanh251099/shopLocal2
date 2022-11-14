using shopLocal.Application.Catalog.Products.Dtos;
using shopLocal.Application.Catalog.Products.Dtos.Public;
using shopLocal.Application.Dtos;
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
