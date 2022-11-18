using Microsoft.EntityFrameworkCore;
using TanuTest.Models.DB;

namespace TanuTest.Repository
{
    public class ProductRepo : IProduct
    {
        private readonly ProductContext _context;

        public ProductRepo(ProductContext context)
        {
            _context = context;
        }
        public IEnumerable<ProductInfo> GetAll()
        {
            return _context.ProductInfo.ToList();
        }

        public ProductInfo GetById(int id)
        {
            return _context.ProductInfo.Where(x => x.Id == id).FirstOrDefault();
        }

        public void ProductPost (ProductInfo entity)
        {
            _context.ProductInfo.Add(entity);
            _context.SaveChanges();
            
        }

  




        //public void ProductPost()
        //{
        //     _context.ProductInfos.ToListAsync();
        //}

        public void ProductUpdate(ProductInfo entity)
        {
            var dbProduct = _context.ProductInfo.Find(entity.Id);

            dbProduct.Title = entity.Title;
            dbProduct.Description = entity.Description;
            _context.Update(dbProduct);
            _context.SaveChanges();
          //  return Ok(await _Context.SuperHeroes.ToListAsync());
        }

        
    }
}
