using BulkyBook.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
	public interface  IUnitOfWork
	{
		public ICategoryRepository Category{ get;}
		public IProductRepository Product { get; }
		public void Save();
		


	}
}
