using System.Collections.Generic;
using System.Collections.ObjectModel;
using rush00.App.ViewModels;
using rush00.Data.Models;

namespace rush00.App.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<HabitCheck> items) {
            Items = new ObservableCollection<HabitCheck>(items);
        }

        public ObservableCollection<HabitCheck> Items { get; }
    }
}