using System.Collections.Generic;
using System.Text.Json;

namespace MauiAppAca4;

public partial class NewPage1 : ContentPage
{
 

    public NewPage1()
    {
        InitializeComponent();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _ = GetEmployees();
    }

    private async Task GetEmployees()
    {
        HttpClient client = new();
        HttpResponseMessage httpResponse = await client.GetAsync("https://localhost:7035/api/Impiegati");
        if (httpResponse.IsSuccessStatusCode)
        {
            string content = await httpResponse.Content.ReadAsStringAsync();
            List<Impiegato> impiegatos   = JsonSerializer.Deserialize<List<Impiegato>>(content);
            lsvImpiegati.ItemsSource = impiegatos;
        }
    }
}