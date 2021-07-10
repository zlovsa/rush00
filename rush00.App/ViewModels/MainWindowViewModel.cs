using rush00.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace rush00.App.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
        public MainWindowViewModel(HabitDbContext db) {
            List = new TodoListViewModel(db.GetItems());
        }

        public TodoListViewModel List { get; }
    }
}
