using System;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesDoApp;
    public ContratacaoHospedagem()
    {
        InitializeComponent();
        PropriedadesDoApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesDoApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

   
        var checkinDate = dtpck_checkin.Date ?? DateTime.Now;
        dtpck_checkout.MinimumDate = checkinDate.AddDays(1);
        dtpck_checkout.MaximumDate = checkinDate.AddMonths(6);
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Erro", ex.Message, "Tudo Ok");
        }
    }


    async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        var elemento = sender as DatePicker;

        if (elemento == null || elemento.Date == null)
            return;

        
        DateTime data_selecionada_checkin = elemento.Date.Value;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddDays(6);
    }


}