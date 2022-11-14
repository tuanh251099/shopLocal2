using Microsoft.EntityFrameworkCore;
using shopLocal.Application.Catalog.Products.Dtos;
using shopLocal.Application.Catalog.Products.Dtos.Manage;
using shopLocal.Application.Dtos;
using shopLocal.Data.EF;
using shopLocal.Data.Entities;
using shopLocal.Utilities.Exceptions;

namespace shopLocal.Application.Catalog.Products
{
    public class ManageProductService : IManagedProductService
    {
        private readonly shopLocalDbContext _context;
        public ManageProductService(shopLocalDbContext context)
        {
            _context = context;
        }

        public async Task AddViewcount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>() 
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId,
                    }
                }
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new shopLocalException("Can not find a product : {productId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //select
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new {p,pt, pic};

            //filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));
            if (request.CategoryId.Count > 0)
            {
                query = query.Where(p => request.CategoryId.Contains(p.pic.CategoryId));
            }

            //Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex-1)*request.PageSize)
                            .Take(request.PageSize)
                            .Select(x => new ProductViewModel()
                            {
                                Id = x.p.Id, 
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

            //Select
            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pageResult;
        }

        public Task<int> Update(Dtos.Manage.ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int ProductId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int ProductId, int addedQuantity)
        {
            throw new NotImplementedException();
        }
    }
}
