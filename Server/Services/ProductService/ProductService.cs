
namespace BlazorEcProject.Server.Services.ProductService
{
	public class ProductService : IProductService
	{
		public readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
		{
			var response = new ServiceResponse<List<Product>>
			{
				Data = await _context.Products.ToListAsync()
			};
			return response;
		}

		public async Task<ServiceResponse<Product>> GetProductsAsync(int productid)
		{
			var response = new ServiceResponse<Product>();
			var product = await _context.Products.FindAsync(productid);
			if (product == null)
			{
				response.Succes = false;
				response.Message = "Sorry, but this product does not exist";
			}
			else
			{
				response.Data = product;
			}
			return response;
		}
	}
}
