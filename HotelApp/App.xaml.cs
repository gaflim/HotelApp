using HotelApp.Models;

namespace HotelApp
{
    public partial class App : Application
    {
        public List<Quarto> Quartos = new List<Quarto>
        {
            new Quarto()
            {
                Desc = "Suíte Super Luxe",
                ValAdulto = 110.0,
                ValCrianca = 55.0,
            },
            
            new Quarto()
            {
                Desc = "Suíte Luxe",
                ValAdulto = 80.0,
                ValCrianca = 40.0,
            },
            
            new Quarto()
            {
                Desc = "Suíte Single",
                ValAdulto = 50.0,
                ValCrianca = 25.0,
            },
            
            new Quarto()
            {
                Desc = "Suíte Críse",
                ValAdulto = 25.0,
                ValCrianca = 12.5,
            },
        };
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ContratarHosp());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height= 600;

            return window;
        }
    }
}
