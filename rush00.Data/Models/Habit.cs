using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rush00.Data.Models
{
	class Habit
	{
		public string Title;
		public string Motivation;
		public List<HabitCheck> Progress;
		public bool IsFinished = false;
	}
}
