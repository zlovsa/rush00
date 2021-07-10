using Microsoft.EntityFrameworkCore;
using rush00.Data.Models;
using System;
using System.Collections.Generic;

namespace rush00.Data
{
	public class HabitDbContext : DbContext
	{
		DbSet<Habit> Habits;
		DbSet<HabitCheck> HabitChecks;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlite("Filename=habits.db");
		}

		public IEnumerable<HabitCheck> GetItems() => new[]
		{
			new HabitCheck { Date = new DateTime(2021,07,01)},
			new HabitCheck { Date = new DateTime(2021,07,02)},
			new HabitCheck { Date = new DateTime(2021,07,03), IsChecked = true }
		};

	}
}
