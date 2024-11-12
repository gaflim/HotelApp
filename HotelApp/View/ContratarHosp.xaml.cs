using HotelApp.Models;

namespace HotelApp.View;

public partial class ContratarHosp : ContentPage
{
	private App appProperties;
	
	// Construtor
	public ContratarHosp()
	{
		InitializeComponent();

		appProperties = (App)Application.Current!;

		PickQuarto.ItemsSource = appProperties.Quartos;

		DtpkCheckin.MinimumDate = DateTime.Now;
		DtpkCheckin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		DtpkCheckout.MinimumDate = DtpkCheckin.Date.AddDays(1);
		DtpkCheckout.MaximumDate = DtpkCheckin.Date.AddMonths(6);
	}

    // Redireciona para a página de confirmação
    private async void Contratar(object? sender, EventArgs e)
    {
	    try
	    {
		    Hospedagem h = new Hospedagem()
		    {
				QuartoSelec = (Quarto) PickQuarto.SelectedItem,
				QntAdulto = Convert.ToInt32(StpAdultos.Value),
				QntCrianca = Convert.ToInt32(StpCriancas.Value),
				
				DataCheckIn = DtpkCheckin.Date,
				DataCheckOut = DtpkCheckout.Date,
		    };
		    
		    await Navigation.PushAsync(new HospContratada()
		    {
			    BindingContext = h
		    });
	    }
	    catch (Exception ex)
	    {
		    await DisplayAlert("Algo deu errado", ex.Message, "OK");
	    }
    }

    // Resolve datas inválidas
    private void DtpkCheckin_OnDateSelected(object? sender, DateChangedEventArgs e)
    {
	    DatePicker? element = sender as DatePicker;
	    if (element == null) return; // Não faz nada caso a data estiver vazia
	    DateTime selectedCheckinDate = element.Date;
	    
	    DtpkCheckout.MinimumDate = selectedCheckinDate.AddDays(1);
	    DtpkCheckout.MaximumDate = selectedCheckinDate.AddMonths(6);
    }
    
    
    // Redireciona para a página sobre
    private async void AboutEvent(object? sender, EventArgs e)
    {
	    await Navigation.PushAsync( new About());
    }
}