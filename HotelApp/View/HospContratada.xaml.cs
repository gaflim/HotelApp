namespace HotelApp.View;

public partial class HospContratada : ContentPage
{
	public HospContratada()
	{
		InitializeComponent();
	}
	
	// Retorna à página principal
	private async void GoBack(object? sender, EventArgs e)
	{
		try
		{
			await Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			await DisplayAlert("Algo deu errado", ex.Message, "OK");
		}
	}
}