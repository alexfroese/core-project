using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;

namespace WebApplicationBasic.Models {
	public class Blog {
		public int BlogId { get; set; }
		public string Title { get; set; }
		public string Link { get; set; }

		public List<Post> Posts { get; set; }
	}

	public class Post {
		public int PostId { get; set; }
		public string Content { get; set; }

		public int BlogId { get; set; }
		public Blog Blog { get; set; }
	}

	public class BloggingContext : DbContext {
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite("Filename=./blog.db");
		}
	}
}