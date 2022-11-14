using Microsoft.EntityFrameworkCore;
using shopLocal.Data.EF;
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
    public class PublicProductService : IPublicProductService
    {
        private readonly shopLocalDbContext _context;
        public PublicProductService(shopLocalDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request)
        {
            // select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pic, pt };
            //filter
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(p => p.pic.CategoryId == request.CategoryId);
            }
            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1)*request.PageSize)
                                  .Take(request.PageSize)
                                  .Select(x => new ProductViewModel()
                                  {
                                    Id= x.p.Id,
                                    Name = x.pt.Name,
                                    DateCreated = x.p.DateCreated,
                                    Description = x.pt.Description,
                                    Details = x.pt.Details,
                                    LanguageId = x.pt.LanguageId,
                                    OriginalPrice = x.pt.OriginalPrice,
                                    Price = x.pt.Price,
                                    SeoAlias = x.pt.SeoAlias,
                                    SeoDescription = x.pt.SeoDescription,
                                    SeoTitle = x.pt.SeoTitle,
                                    Stock = x.pt.Stock,
                                    ViewCount = x.pt.ViewCount
                                  }).ToListAsync();
            //Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pagedResult;
        }
    }
}
