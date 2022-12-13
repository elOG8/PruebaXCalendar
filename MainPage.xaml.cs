using PruebaXCal.ViewModels;

namespace PruebaXCal;

public partial class MainPage : ContentPage
{
	CalendarViewModel vm;
	public MainPage()
	{
		InitializeComponent();
		vm = new CalendarViewModel();
		BindingContext = vm;
	}

}

