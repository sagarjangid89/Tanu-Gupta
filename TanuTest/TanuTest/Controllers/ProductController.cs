using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TanuTest.Models.DB;
using TanuTest.Repository;


namespace TanuTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _repository;
        private readonly DataContext _Context;

        public ProductController(IProduct repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetDetail()
        {
            var result = this._repository.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(ProductInfo product)
        {


            this._repository.ProductPost(product);
       
            return Ok("Success");
        }


        [HttpPut]
        public IActionResult Update(ProductInfo product)
        {

            this._repository.ProductUpdate(product);
            return Ok("Updated");

        }




    }
}
