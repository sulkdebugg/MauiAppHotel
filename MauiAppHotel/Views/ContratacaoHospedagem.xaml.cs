using System;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }
}