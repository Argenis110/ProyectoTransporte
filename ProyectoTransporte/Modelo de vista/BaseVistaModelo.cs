using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTransporte.Modelo_de_vista
{
    public partial class BaseVistaModelo : ObservableObject

    {
        [ObservableProperty]
        public bool _ocupado;
        [ObservableProperty]
        public string _titulo;

    }
}
