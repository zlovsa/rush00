using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rush00.Data.Models
{
	public class HabitCheck
	{
		public DateTime Date;
		public bool IsChecked = false;
		public string DateStr => Date.ToShortDateString();
	}
}
