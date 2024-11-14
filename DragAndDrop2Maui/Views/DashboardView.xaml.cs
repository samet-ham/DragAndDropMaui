using DragAndDrop2Maui.ViewModels;

namespace DragAndDrop2Maui.Views;

public partial class DashboardView : ContentPage
{
	public DashboardView()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}
}