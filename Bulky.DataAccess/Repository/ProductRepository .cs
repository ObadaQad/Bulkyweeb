﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.DataAccess.Data;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>,IProductRepository	
	{
		private ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)	
		{
			_db = db; 		
		
		}

		public void Save()
		{
			_db.SaveChanges();
		}

		public void Update(Product obj)
		{
			var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
			if (objFromDb != null)
			{
				objFromDb.Title  = obj.Title;
				objFromDb.Description = obj.Description;			
				objFromDb.Author = obj.Author;
				objFromDb.CategoryId = obj.CategoryId;
				objFromDb.Price=obj.Price;
				objFromDb.Price100 = obj.Price100;
				objFromDb.Price50 = obj.Price50;
				objFromDb.ISBN = obj.ISBN;
				objFromDb.ListPrice = obj.ListPrice;
				if (objFromDb.ImageUrl !=null	)
				{
					objFromDb.ImageUrl = obj.ImageUrl;
				

				}
			}
		}
	}

}
