namespace Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent(); // Configura la interfaz definida en XAML
    }

    // Método para el botón "Llamar al 911"
    private async void OnCounterBtnClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Emergencia", "Llamando al 911...", "OK");
    }

    // Método para el botón "Enviar Ubicación"
    private async void OnShareLocationClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ubicación", "Enviando tu ubicación actual...", "OK");
        // Aquí puedes integrar lógica para enviar la ubicación real
    }

    // Método para el botón "Primeros Auxilios"
    private async void OnFirstAidClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Primeros Auxilios", "Consulta la guía de primeros auxilios.", "OK");
        // Aquí podrías abrir otra página con información detallada
    }
}
