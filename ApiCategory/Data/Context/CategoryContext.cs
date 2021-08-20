using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
	public class CategoryContext : DbContext
	{
		public DbSet<Category> Category { get; set; }
		public CategoryContext():base(@"Data Source=192.168.0.152;Initial Catalog=Guizin;Persist Security Info=True;User ID=Guilherme;Password=123@")
		{
		}
	}
}
