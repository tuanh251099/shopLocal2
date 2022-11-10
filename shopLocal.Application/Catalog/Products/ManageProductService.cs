using Microsoft.IdentityModel.Tokens;
using shopLocal.Application.Catalog.Products.Dtos;
using shopLocal.Application.Dtos;
using shopLocal.Data.EF;
using shopLocal.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Application.Catalog.Products
{
    public class ManageProductService : IManagedProductService
    {
        private readonly shopLocalDbContext _context;
        public ManageProductService(shopLocalDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(int productId)
        {

        }
        public async Task<List<ProductViewModel>> GetAll()
        {

        }
        public async Task<PagedViewModel<ProductViewModel>> GetAllPaing(string keyword, int pageIndex,int pageSize)
        {

        }
        public async Task<int> Update(ProductEditRequest request)
        {

        }

        int IManagedProductService.Create(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
