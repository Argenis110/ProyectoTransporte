namespace ProyectoTransporte.Vistas;

public partial class Principal : ContentPage
{
    string[] usuarios = { "FloresJose", "1" };
    string[] contraseñas = { "Roldos01", "1" };
    public Principal()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);

    }


    private async void NuevaCuenta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.nuevaCuenta());
    }

    private void BtnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contraseñaIngresada = txtContraseña.Text;

        // Verificar si los campos de usuario y contraseña están vacíos
        if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(contraseñaIngresada))
        {
            // Salir de la función sin hacer nada si los campos están vacíos
            return;
        }

        bool usuarioValido = false;
        int indiceUsuario = -1;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contraseñaIngresada == contraseñas[i])
            {
                usuarioValido = true;
                indiceUsuario = i;
                break;
            }
        }

        if (usuarioValido)
        {
            string nombreUsuario = usuarios[indiceUsuario];

            // Crear instancia de Pagina1 con el nombre de usuario
            Pagina1 newPage = new Vistas.Pagina1(nombreUsuario);

            // Obtener la instancia actual del NavigationPage
            NavigationPage navigationPage = Application.Current.MainPage as NavigationPage;

            // Restablecer la instancia de navegación al volver a la página anterior
            navigationPage.PopAsync();

            // Establecer la nueva página como la página principal
            navigationPage.PushAsync(newPage);
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO/CONTRASEÑA INCORRECTA", "INTENTAR NUEVAMENTE");
        }
    }

}