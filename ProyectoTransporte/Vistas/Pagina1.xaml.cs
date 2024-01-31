namespace ProyectoTransporte.Vistas;

public partial class Pagina1 : ContentPage
{
    
    public string NombreUsuarioConectado { get; set; }
    public Pagina1(string nombreUsuario)
    {
        InitializeComponent();
        
        NavigationPage.SetHasNavigationBar(this, false);
        NombreUsuarioConectado = nombreUsuario;
        TituloLabel.Text = $" !Bienvenido {NombreUsuarioConectado}�";
        
    }

    
    private async void Button_Conductor_Clicked(object sender, EventArgs e)
    {


        await Navigation.PushAsync(new Vistas.Pagina2());

    }

    private void Button_Transporte_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Ordenes_Clicked(object sender, EventArgs e)
    {

    }
}