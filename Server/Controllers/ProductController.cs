﻿using BlazorEcProject.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcProject.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		public ProductController() {}

		//simula la DB
		private static List<Product> Products = new List<Product>
	{
		new Product
		{
			Id = 1,
			Title = "The Hitchhiker's Guide to the Galaxy",
			Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. ",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
			Price = 9.99m
		},
				new Product
		{
			Id = 2,
			Title = "Ready Player One",
			Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. ",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
			Price = 6.99m
		},
				new Product
		{
			Id = 3,
			Title = "Nineteen Eighty-Four",
			Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell.",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg",
			Price = 8.99m
		}

	};

		[HttpGet]
		public async Task<IActionResult> GetProduct()
		{
			//Ok()devuelve una respuesta HTTP 200
			return Ok(Products);
		}
	}
}