using TanuTest.Models.DB;

namespace TanuTest.Repository
{
    public interface IProduct
    {
        IEnumerable<ProductInfo> GetAll();
        ProductInfo GetById(int id);
        void ProductPost(ProductInfo entity);
        void ProductUpdate(ProductInfo entity);


    }
}
