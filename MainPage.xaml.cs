using PruebaXCal.ViewModels;

namespace PruebaXCal;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new CalendarViewModel();
	}

}

