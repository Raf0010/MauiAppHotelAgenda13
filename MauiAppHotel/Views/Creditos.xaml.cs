namespace MauiAppHotel.Views
{
    public partial class Créditos : ContentPage
    {
        public Créditos()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContratacaoHospedagem());
        }
    }
}