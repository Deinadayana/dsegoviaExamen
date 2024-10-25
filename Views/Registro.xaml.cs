namespace dsegoviaExamen.Views;

public partial class Registro : ContentPage
{
    private int montoInicial;
    string user_global = "";

    public Registro(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario Conectado" + " " + usuario;
        user_global = usuario;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            
            montoInicial = int.Parse(montoInicialEntry.Text);

            if (montoInicial < 1499)
            {
                double montoInicial = double.Parse(montoInicialEntry.Text);
                double cuotaMensual = (1500 - montoInicial) / 4 * 1.04;
            
                pagoMensualEntry.Text = cuotaMensual.ToString("F2");
             }
            else
            {

                DisplayAlert("Error", "El monto inicial no puede ser mayor a 1500.", "OK");
                montoInicialEntry.Text = string.Empty;
                pagoMensualEntry.Text = string.Empty;
                return;
            }
        }
        catch (FormatException)
        {
            DisplayAlert("Error", "Por favor, ingrese un número válido para el monto inicial.", "OK");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
        string nombre = nombreEntry.Text;
        string apellido = apellidoEntry.Text;
        int edad = int.Parse(edadEntry.Text);
        DateTime fecha = ((DatePicker)FindByName("Fecha")).Date;
        string ciudad = cuidadPicker.SelectedItem.ToString();
        string pais = paisPicker.SelectedItem.ToString();
        double montoInicial = double.Parse(montoInicialEntry.Text);
        double pagoMensual = double.Parse(pagoMensualEntry.Text);

        await Navigation.PushAsync(new Resumen(user_global, nombre, apellido, edad, fecha, ciudad, pais, montoInicial, pagoMensual));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Falta ingresar datos ", "OK");
        }
    }
}