namespace dsegoviaExamen.Views;

public partial class Login : ContentPage
{
    private string[] usuarios = { "Estudiante", "uisrael" };
    private string[] contrase�as = { "moviles", "2024"};
    public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuario == usuarios[i] && contrase�a == contrase�as[i])
            {
                await Navigation.PushAsync(new Registro(usuario));
                return;
            }
        }

        await DisplayAlert("Error", "Usuario o contrase�a incorrectos.", "OK");
    }

}







