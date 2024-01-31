namespace ProyectoTransporte.Vistas;

public partial class Principal : ContentPage
{
    string[] usuarios = { "FloresJose", "1" };
    string[] contrase�as = { "Roldos01", "1" };
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
        string contrase�aIngresada = txtContrase�a.Text;

        // Verificar si los campos de usuario y contrase�a est�n vac�os
        if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(contrase�aIngresada))
        {
            // Salir de la funci�n sin hacer nada si los campos est�n vac�os
            return;
        }

        bool usuarioValido = false;
        int indiceUsuario = -1;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contrase�aIngresada == contrase�as[i])
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

            // Restablecer la instancia de navegaci�n al volver a la p�gina anterior
            navigationPage.PopAsync();

            // Establecer la nueva p�gina como la p�gina principal
            navigationPage.PushAsync(newPage);
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO/CONTRASE�A INCORRECTA", "INTENTAR NUEVAMENTE");
        }
    }

}