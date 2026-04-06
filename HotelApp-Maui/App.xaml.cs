using HotelApp_Maui.Models;

namespace HotelApp_Maui
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110,
                ValorDiariaCrianca = 55
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80,
                ValorDiariaCrianca = 40
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suíte Simples",
                ValorDiariaAdulto = 30,
                ValorDiariaCrianca = 15
            },
        };


        public App()
        {
            InitializeComponent();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.ContratacaoHospedagem()));
        }
    }
}