using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace Login
{
    public sealed partial class MainWindow : Window
    {
        // Credenciales de ejemplo
        private const string UsuarioCorrecto = "admin";
        private const string ContrasenaCorrecta = "1234";

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            bool valido = txtUsuario.Text == UsuarioCorrecto &&
                          txtContrasena.Password == ContrasenaCorrecta;

            ContentDialog dialogo = new ContentDialog
            {
                Title = valido ? "Bienvenido" : "Error",
                Content = valido ? "Se inició sesión correctamente."
                                 : "Usuario o contraseña incorrectos.",
                CloseButtonText = "Aceptar",
                XamlRoot = this.Content.XamlRoot
            };

            await dialogo.ShowAsync();
        }
    }
}