using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using rush00.App.ViewModels;
using rush00.App.Views;
using rush00.Data;

namespace rush00.App
{
	public class App : Application
	{
		public override void Initialize() {
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted() {
			base.OnFrameworkInitializationCompleted();

			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
				var db = new HabitDbContext();
				desktop.MainWindow = new MainWindow {
					DataContext = new MainWindowViewModel(db),
				};
			}

		}
	}
}
