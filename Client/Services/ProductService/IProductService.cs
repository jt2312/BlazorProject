﻿
namespace BlazorEcProject.Client.Services.ProductService
{
	public interface IProductService 
	{
		event Action ProductsChange;
		List<Product> Products { get; set; }
		Task GetProducts(string? categoryUrl = null);
		Task<ServiceResponse<Product>> GetProductById(int productId);

	}
}
