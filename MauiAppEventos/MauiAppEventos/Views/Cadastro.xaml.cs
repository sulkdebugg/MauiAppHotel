using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class Cadastro: ContentPage
{
    Evento evento = new Evento();

    public Cadastro()
    {
        InitializeComponent();

        BindingContext = evento;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoEventoPage(evento));
    }
}