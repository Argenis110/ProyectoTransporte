using ProyectoTransporte.Modelos;

namespace ProyectoTransporte
{
    public partial class App : Application
    {
        public static UsuarioInfo usuarioInfo;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.Principal());
        }
    }
}
