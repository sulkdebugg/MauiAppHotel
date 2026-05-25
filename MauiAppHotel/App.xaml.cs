using MauiAppHotel.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaCrianca = 250.00,
                ValorDiariaAdulto = 500.00
            },

             new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaCrianca = 20.00,
                ValorDiariaAdulto = 50.00
            },

              new Quarto()
            {
                Descricao = "Suíte da Crise",
                ValorDiariaCrianca = 20.00,
                ValorDiariaAdulto = 8.00
            },
        };

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}