﻿using ProyectoTransporte.Modelos;

namespace ProyectoTransporte
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.Principal());
        }
    }
}
