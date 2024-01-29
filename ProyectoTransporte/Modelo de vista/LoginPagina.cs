using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using ProyectoTransporte.Modelos;
using ProyectoTransporte.Servicios;
using ProyectoTransporte.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoTransporte.Modelo_de_vista
{
    public partial class LoginPagina  : BaseVistaModelo
    {
        [ObservableProperty]
        private string _usuario;
        [ObservableProperty]
        private string _contraseña;

        readonly ILoginRepositorio loginRepositorio = new LoginServicio();

        /*[ICommand]
        public async void Login()
        {
            if(!string.IsNullOrWhiteSpace(Usuario) && !string.IsNullOrWhiteSpace(Contraseña))
            {
                UsuarioInfo usuarioInfo = await loginRepositorio.Login(Usuario, Contraseña);
                if(Preferences.ContainsKey(nameof(App.usuarioInfo)))
                {
                    Preferences.Remove(nameof(App.usuarioInfo));
                }
                string userDetails = JsonConvert.SerializeObject(usuarioInfo);
                Preferences.Set(nameof(App.usuarioInfo),userDetails);
                App.usuarioInfo = usuarioInfo;

                await Shell.Current.GoToAsync($"//{nameof(Principal)}");
            }    

        }*/
    }
}
