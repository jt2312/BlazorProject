namespace BlazorEcProject.Server.Services.ProductService
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductsAsync();
		Task<ServiceResponse<Product>> GetProductsAsync(int productid);

	}
}
