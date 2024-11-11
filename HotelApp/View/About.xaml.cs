namespace HotelApp.View;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}