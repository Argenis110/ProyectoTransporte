
using Newtonsoft.Json;
using ProyectoTransporte.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTransporte.Servicios
{
    public interface ILoginRepositorio
    {
        /*async Task<UsuarioInfo> Login(string nombre, string contraseña)
        {
            try
            {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var usuarioinfo = new UsuarioInfo();
                    var cliente = new HttpClient();
                    //string url = "http://192.168.61.40.8099/api/UserInfoes/LoginUser/"+ username+"/"+password;
                    string url = "http://192.168.1.107:8099/api/UserInfoes/LoginUser/" + nombre + "/" + contraseña;
                    cliente.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await cliente.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {
                        string content = response.Content.ReadAsStringAsync().Result;
                        //usuarioinfo = JsonConvert.DeserializeObject<List<UsuarioInfo>>(content);
                        usuarioinfo = await response.Content.ReadFromJsonAsync<UsuarioInfo>();
                        return await Task.FromResult(usuarioinfo);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }*/
    }
}
