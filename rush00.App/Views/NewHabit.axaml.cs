using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace rush00.App.Views
{
	public partial class NewHabit : Window
	{
		public NewHabit() {
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		private void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}
}
