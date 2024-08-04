using BlazorEcProject.Server.Data;
using BlazorEcProject.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcProject.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly DataContext _context;

		public ProductController(DataContext context)
		{
			_context = context;
		}
 
		[HttpGet]
		public async Task<IActionResult> GetProduct()
		{
			//Ok()devuelve una respuesta HTTP 
			var products = await _context.Products.ToListAsync();
			return Ok(products);
		}
	}
}
