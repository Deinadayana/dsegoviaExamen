namespace dsegoviaExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen(string user_global, string nombre, string apellido, int edad, DateTime fecha, string ciudad, string pais, double montoInicial, double pagoMensual)

    {
		InitializeComponent();
        lblUsuario.Text = "Usuario Conectado" + " " + user_global;
        lblnombre.Text = nombre;
        lblapellido.Text = apellido;
        lbledad.Text = edad.ToString();
        lblfecha.Text = fecha.ToShortDateString();
        lblciudad.Text = ciudad;
        lblpais.Text = pais;
        lblmontoInicial.Text = montoInicial.ToString("F2");
        lblpagoMensual.Text = pagoMensual.ToString("F2");
        double pagoTotal = montoInicial + (pagoMensual * 4);
        lblpagoTotal.Text = pagoTotal.ToString("F2");

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }

  
}