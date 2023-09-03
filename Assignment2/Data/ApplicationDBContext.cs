using System;
using Assignment2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Data
{
	public class ApplicationDBContext: DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
		{

		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Professor> Professors { get; set; }

	}
}

