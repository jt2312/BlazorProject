using BlazorEcProject.Shared;

namespace BlazorEcProject.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		Task GetProducts();

	}
}
