namespace ProyectoTransporte.Vistas;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
        
	}


    private void NuevaCuenta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.nuevaCuenta());
    }

    private void Iniciar_Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.nuevaCuenta());
    }

    private void BtnIniciar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.nuevaCuenta());
    }
}