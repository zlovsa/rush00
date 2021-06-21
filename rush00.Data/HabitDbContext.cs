using Microsoft.EntityFrameworkCore;
using rush00.Data.Models;
using System;

namespace rush00.Data
{
	public class HabitDbContext : DbContext
	{
		DbSet<Habit> Habits;
		DbSet<HabitCheck> HabitChecks;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite("Filename=habits.db");
		}

	}
}
